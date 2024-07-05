using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ABSTRACCION;

namespace UI
{
    public partial class frmPermisos : Form, ITraducible
    {
        public frmPermisos()
        {
            InitializeComponent();
            bllPadre = new BLLPadre();
            bllHijo = new BLLHijo();
            Registrarse();
            Actualizar();

        }

        BLLPadre bllPadre;
        BLLHijo bllHijo;

        BEPadre padre;
        BEPadre oPadre;
        BEPadre oPadreEliminado;
        BEPadre oPadreAnterior;
        BEPadre oPadrePrincipal;
        BEHijo hijo;

        BLLPermiso bllPermiso;
        IList<BEPermiso> lPermiso;
        IList<BEPermiso> lPermisoAnteriores;
        IList<BEPermiso> lPermisosEliminados;

        List<(int IdPadre, int IdHijo)> relacionesPatentesEliminadas;

        public void Registrarse()
        {
            BLLTraductor BllTraductor = new BLLTraductor();
            BllTraductor.RegistrarForm(this);
        }

        public void Actualizar()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEPalabra> Palabras = bllTraductor.ObtenerPalabras();

            try
            {
                if (this.Tag != null & this.Tag != "")
                {
                    this.Text = Palabras.Find(pal => pal.Tag.Equals(Tag)).Texto;
                }
                foreach (Control control in Controls)
                {
                    if (control.Tag != null & control.Tag != "")
                    {
                        control.Text = Palabras.Find(pal => pal.Tag.Equals(control.Tag)).Texto;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan traducciones");
            }
        }
        private void frmPermisos_Load(object sender, EventArgs e)
        {
            LlenarComboMenu();
            LlenarComboSubmenu();
        }

        private void LlenarComboSubmenu()
        {
            this.cmbBoxNombreSubMenu.DataSource = bllHijo.ObtenerHijos();
        }

        private void LlenarComboMenu()
        {
            this.cmbBoxMenuLista.DataSource = null;

            cmbBoxMenuLista.DataSource = bllPadre.ObtenerMenus();
        }

        private void btnMenuEditar_Click(object sender, EventArgs e)
        {
            oPadre = (BEPadre)cmbBoxMenuLista.SelectedItem;

            recuperarObjetoPadre();

            llenarPadreTreeView(lPermiso);
            lPermisoAnteriores = lPermiso;
            oPadrePrincipal = oPadre;
            cmbBoxMenuLista.SelectedItem = null;
            LlenarComboMenu();
        }

        private void llenarPadreTreeView(IList<BEPermiso> l)
        {
            lPermiso = l;

            treeView1.Nodes.Clear();// limpio el tree view 

            TreeNode root = new TreeNode(oPadre.NombrePermiso);
            root.Tag = oPadre;
            treeView1.Nodes.Add(root);

            foreach (var item in lPermiso)
            {
                LlenarTreeNode(root, item);
            }

            treeView1.ExpandAll();
        }

        private void LlenarTreeNode(TreeNode tree, BEPermiso permiso)
        {
            TreeNode treenode = new TreeNode(permiso.NombrePermiso);

            treenode.Tag = permiso;
            tree.Nodes.Add(treenode);
            if (permiso.SubComponentes != null)
                foreach (var item in permiso.SubComponentes)
                {
                    LlenarTreeNode(treenode, item);
                }
        }

        private void recuperarObjetoPadre()
        {
            lPermiso = bllPadre.ObtenerArbolMenu(oPadre); //aplico recursividad desde la base de datos
            foreach (var item in lPermiso)
            {
                oPadre.AgregarSubcomponente(item);// agrego los hijos
            }
        }

        private void btnMenuNuevo_Click(object sender, EventArgs e)
        {
            txtBoxNombreMenu.Visible = true;
            btnMenuNuevoGuardar.Visible = true;
            lblNombreNuevoMenu.Visible = true;


            btnMenuNuevo.Visible = false;
            lblMenuLista.Visible = false;
            cmbBoxMenuLista.Visible = false;
        }

        private void btnMenuSeleccionar_Click(object sender, EventArgs e)
        {
            if (oPadre != null)// evito que si presionan seleccionar sin haber hecho clic en modificar primero , no rompa 
            {
                oPadrePrincipal = oPadre;
                oPadre = null;
                oPadre = new BEPadre();
                oPadre.VaciarSubcomponente();

                oPadre = (BEPadre)cmbBoxMenuLista.SelectedItem;
                if (bllPadre.RevisarArbolMenu(oPadrePrincipal, oPadre.Id) == false)
                {


                    recuperarObjetoPadre();


                    oPadrePrincipal.AgregarSubcomponente(oPadre);
                    oPadre = oPadrePrincipal;
                    lPermiso = oPadre.SubComponentes;

                    llenarPadreTreeView(lPermiso);
                }
                else
                {

                    oPadre = oPadrePrincipal;
                    MessageBox.Show("Permiso ya existente");
                }

            }
            cmbBoxMenuLista.SelectedItem = null;
            LlenarComboMenu();
        }

        private void btnMenuNuevoGuardar_Click(object sender, EventArgs e)
        {
            txtBoxNombreMenu.Visible = false;
            btnMenuNuevoGuardar.Visible = false;
            lblNombreNuevoMenu.Visible = false;



            btnMenuNuevo.Visible = true;
            lblMenuLista.Visible = true;
            cmbBoxMenuLista.Visible = true;

            // Nuevo menu

            padre = new BEPadre();
            padre.NombrePermiso = this.txtBoxNombreMenu.Text;
            bllPadre.GuardarPermiso(padre);

            LlenarComboMenu();
            MessageBox.Show("Padre guardado correctamente");
            txtBoxNombreMenu.Text = "";
        }

        private void btnSubMenuSeleccionar_Click(object sender, EventArgs e)
        {
            if (oPadre != null)// evito que si presionan seleccionar sin haber hecho clic en modificar primero , no rompa 
            {
                oPadrePrincipal = oPadre;
                BEHijo oHijo;
                oHijo = (BEHijo)cmbBoxNombreSubMenu.SelectedItem;
                if (bllPadre.RevisarArbolMenu(oPadrePrincipal, oHijo.Id) == false)
                {
                    if (oHijo != null)
                    {
                        oPadrePrincipal = oPadre;
                        oPadre.AgregarSubcomponente(oHijo);
                        lPermiso = oPadre.SubComponentes;
                        oPadre = oPadrePrincipal;
                        llenarPadreTreeView(lPermiso);

                    }
                }
                else
                {

                    oPadre = oPadrePrincipal;
                    MessageBox.Show("Permiso ya existente");
                }

            }
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            // Le paso Menu padre, Lista de permisos anteriores, lista de permisos editados
            bllPadre.ActualizarPermisos(oPadrePrincipal, lPermisoAnteriores, lPermiso, relacionesPatentesEliminadas);



            MessageBox.Show("Estructura de permisos guardada correctamente");
            padre = null;
            oPadre = null;
            oPadreAnterior = null;
            oPadrePrincipal = null;
            hijo = null;


            LlenarComboMenu();
            treeView1.Nodes.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TreeNode nodoSeleccionado = treeView1.SelectedNode;
            if (nodoSeleccionado != null)
            {
                //consulto si es padre
                if (EsPadre(nodoSeleccionado))//Verifico si es Padre
                {
                    BEPadre padreEliminar = (BEPadre)nodoSeleccionado.Tag;

                    int idPadre = padreEliminar.Id;
                    int idPadree = ObtenerIdPadreRaizAnterior(treeView1.SelectedNode, idPadre);



                    // Eliminar el nodo seleccionado del tree view 
                    lPermisosEliminados = lPermiso;
                    BEPadre oPadreliminado = oPadre;
                    oPadreEliminado.VaciarSubcomponente();




                    if (idPadre != oPadrePrincipal.Id)// si el padre a eliminar no es el padre raiz
                    {
                        foreach (var item in lPermisosEliminados)
                        {
                            if (item.Id != idPadre)
                            {
                                oPadreEliminado.AgregarSubcomponente(item);// agrego los hijos
                            }

                        }

                    }

                    lPermiso = oPadreEliminado.SubComponentes;
                    llenarPadreTreeView(lPermiso);



                }
                else if (EsHijo(nodoSeleccionado))//Verifico si es Hijo
                {
                    BEHijo HijoEliminar = (BEHijo)nodoSeleccionado.Tag;
                    int idHijo = HijoEliminar.Id;
                    int idPadre = ObtenerIdPadreDesdeHijo(treeView1.Nodes[0], idHijo);

                    lPermisosEliminados = lPermiso;
                    BEHijo oHijoEliminado = new BEHijo();

                    BEPadre oPadreEliminado = oPadre;
                    oPadreEliminado.VaciarSubcomponente();
                    relacionesPatentesEliminadas = new List<(int IdPadre, int IdHijo)>();
                    relacionesPatentesEliminadas.Add((idPadre, idHijo));
                    foreach (var item in lPermisosEliminados)
                    {
                        if (item.Id == idPadre) // Verificar si es el menú buscado
                        {
                            BEPadre oPadreEliminadoJerarquia = new BEPadre(); // Crear nueva instancia de BEMenu para el menú eliminado
                            oPadreEliminadoJerarquia.Id = item.Id;
                            oPadreEliminadoJerarquia.NombrePermiso = item.NombrePermiso;
                            oPadreEliminadoJerarquia.VaciarSubcomponente();

                            foreach (var subItem in item.SubComponentes)
                            {
                                if (subItem.Id != idHijo)
                                {
                                    BEHijo nuevoHijo = new BEHijo(); // Crear nueva instancia de BESubmenu para el submenú eliminado
                                    nuevoHijo.Id = subItem.Id;
                                    nuevoHijo.NombrePermiso = subItem.NombrePermiso;


                                    oPadreEliminadoJerarquia.AgregarSubcomponente(nuevoHijo);
                                }
                            }

                            oPadreEliminado.AgregarSubcomponente(oPadreEliminadoJerarquia);
                        }
                        else
                        {
                            oPadreEliminado.AgregarSubcomponente(item);
                        }
                    }

                    lPermiso = oPadreEliminado.SubComponentes;


                    if (nodoSeleccionado != null) //&& nodoSeleccionado != treeView1.Nodes[0])
                    {
                        // Eliminar el nodo del árbol
                        treeView1.Nodes.Remove(nodoSeleccionado);
                    }



                }


            }
            cmbBoxMenuLista.SelectedItem = null;
            LlenarComboMenu();

        }

        private bool EsPadre(TreeNode nodo)
        {

            // Verifica si el nodo es un menu
            BEPadre padre = nodo.Tag as BEPadre;
            return padre != null;
        }

        private int ObtenerIdPadreRaizAnterior(TreeNode nodo, int idPadre)
        {
            if (nodo == null)
                return -1;

            if (nodo.Tag is BEPadre)
            {
                BEPadre padre = (BEPadre)nodo.Tag;
                if (padre.Id == idPadre)
                {
                    TreeNode nodoPadre = nodo.Parent;
                    if (nodoPadre != null && nodoPadre.Tag is BEPadre)
                    {
                        BEPadre menuPadre = (BEPadre)nodoPadre.Tag;
                        return menuPadre.Id;
                    }
                }
            }

            return ObtenerIdPadreRaizAnterior(nodo.Parent, idPadre);
        }

        private bool EsHijo(TreeNode nodo)
        {
            // Verifica si el nodo es un submenu
            BEHijo hijo = nodo.Tag as BEHijo;
            return hijo != null;
        }

        private int ObtenerIdPadreDesdeHijo(TreeNode nodo, int idHijo)
        {
            if (nodo == null)
                return -1;

            if (nodo.Tag is BEHijo)
            {
                BEHijo hijo = (BEHijo)nodo.Tag;
                if (hijo.Id == idHijo)
                {
                    TreeNode nodoPadre = nodo.Parent;
                    if (nodoPadre != null && nodoPadre.Tag is BEPadre)
                    {
                        BEPadre menuPadre = (BEPadre)nodoPadre.Tag;
                        return menuPadre.Id;
                    }
                }
            }

            foreach (TreeNode hijo in nodo.Nodes)
            {
                int idPadre = ObtenerIdPadreDesdeHijo(hijo, idHijo);
                if (idPadre != -1)
                    return idHijo;
            }

            return -1;
        }

       
    }
}
