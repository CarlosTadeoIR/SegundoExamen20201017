namespace Examen2;

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
        InicializarComponentes2();
    }

    private void InicializarComponentes2(){
        this.Size=new Size(250,200);
        this.Text="Nueva ventana";
        
        lblMensaje.AutoSize=true;
        lblMensaje.Location= new Point(60,60);

        btnCerrar.Text="Cancelar";
        btnCerrar.AutoSize=true;
        btnCerrar.Location=new Point(25,120);
        btnCerrar.Click+= new EventHandler(btnCerrar_Click);

        this.Controls.Add(lblMensaje);
        this.Controls.Add(btnCerrar);
    }
    
    private void btnCerrar_Click(Object? sender, EventArgs e){
        this.DialogResult=DialogResult.OK;
        this.Close();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}
