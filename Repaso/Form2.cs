namespace Repaso;

public partial class Form2 : Form
{
    public Label lblMensaje;
    private Button btnCerrar;
    public String mensaje;

    public Form2()
    {
        lblMensaje=new Label();
        btnCerrar=new Button();
        mensaje="";
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size=new Size(250,200);
        this.Text="Nueva ventana";
        lblMensaje.Text="Esta es una nueva ventana";
        lblMensaje.AutoSize=true;
        lblMensaje.Location= new Point(60,60);

        btnCerrar.Text="Cerrar";
        btnCerrar.AutoSize=true;
        btnCerrar.Location=new Point(70,100);
        btnCerrar.Click+= new EventHandler(btnCerrar_Click);

        this.Controls.Add(lblMensaje);
        this.Controls.Add(btnCerrar);
    }

    private void btnCerrar_Click(Object? sender, EventArgs e){
        mensaje="ventana cerrda";
        this.DialogResult=DialogResult.OK;
        this.Close();
    }
}
