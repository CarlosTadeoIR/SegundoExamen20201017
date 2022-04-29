namespace Repaso;

public partial class Form1 : Form
{
    private Button btnVentana;
    private int num;
    public Form1()
    {
        btnVentana=new Button();
        num=1;
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        btnVentana.Text="Abrir Nueva Ventana";
        btnVentana.AutoSize=true;
        //btnVentana.Size = new Size(200,300);
        btnVentana.Location= new Point(10,10);
        btnVentana.Click+=new EventHandler(btnVentana_Click);

        this.Controls.Add(btnVentana);
    }
    private void btnVentana_Click(object? sender, EventArgs e){
        Form2 frmVentana=new Form2();
        if(frmVentana.ShowDialog()==DialogResult.OK){
            Label lblAgregado = new Label();
            lblAgregado.Text=frmVentana.mensaje;
            lblAgregado.AutoSize=true;
            lblAgregado.Location=new Point(10,30*num);
            num++;
            this.Controls.Add(lblAgregado);
        }
    }
}
