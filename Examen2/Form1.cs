namespace Examen2;

public partial class Form1 : Form
{   
    private Label? lblMoneda;
    private ComboBox? cmbMoneda;
    private Label? lblMonto;
    private TextBox? txtMonto;
    private Button? btnCalcular;
    private Panel plResultados;
    private TextBox? txtBase;
    public Form1()
    {
        btnCalcular=new Button();
        plResultados=new Panel();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(350,350);

        //Etiqueta Moneda
        lblMoneda= new Label();
        lblMoneda.Text="Moneda";
        lblMoneda.AutoSize=true;
        lblMoneda.Location= new Point(10,10);

        //ComboBox Monedas
        cmbMoneda = new ComboBox();
        cmbMoneda.Size = new Size(170,20);
        
        cmbMoneda.Items.Add("USD-Dolar estadounidense");
        cmbMoneda.SelectedIndex=0;
        cmbMoneda.Items.Add("MXN-Peso mexicano");
        cmbMoneda.Items.Add("CAD-Dolar Canadiense");
        cmbMoneda.Items.Add("EUR-Euro");
        cmbMoneda.Items.Add("JPY-Yen japones");
        cmbMoneda.Location= new Point(10,40);
       

        //Etiqueta Monto
        lblMonto= new Label();
        lblMonto.Text="Monto";
        lblMonto.AutoSize=true;
        lblMonto.Location= new Point(190,10);

        plResultados= new Panel();
        plResultados.Size= new Size(200,200);
        plResultados.Location= new Point(190,10);

        //TextBox Monto
        txtMonto=new TextBox();
        txtMonto.Size = new Size(100,20);
        txtMonto.Location= new Point(190,40);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,70);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);
        

        //Agregar controles a la ventana
        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmbMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        //this.Controls.Add(plResultados);
        
    }
    private void btnCalcular_Click(object? sender, EventArgs e){
        

        Form2 formulario = new Form2();
        if(formulario.ShowDialog()==DialogResult.OK){
            
        }
        /*if(formulario.ShowDialog()==DialogResult.OK){
            Label lblAgregado = new Label();
            lblAgregado.Text=formulario.mensaje;
            lblAgregado.AutoSize=true;
            lblAgregado.Location=new Point(10,30*num);
            num++;
            this.Controls.Add(lblAgregado);
        }*/
    }

   
}
