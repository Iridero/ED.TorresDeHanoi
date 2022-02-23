namespace ED.TorresDeHanoi
{
    public partial class FrmHanoi : Form
    {
        public FrmHanoi()
        {
            InitializeComponent();
        }

        Stack<Panel> discos = new Stack<Panel>();
        char panelSeleccionado = ' ';

        Juego juego = new Juego();
        private void FrmHanoi_Load(object sender, EventArgs e)
        {
            CrearDiscos(5);
            while (discos.Count > 0)
            {
                Panel disco = discos.Pop();
                areaPosteA.Controls.Add(disco);
            }

            juego.Iniciar(5);
            juego.DiscoMovido += Juego_DiscoMovido;
        }

        private void Juego_DiscoMovido(char Origen, char Destino)
        {
            Panel disco;
            Panel origen;
            Panel destino;
            switch (Origen)
            {
                case 'A':
                    origen = areaPosteA;
                    break;
                case 'B':
                    origen = areaPosteB;
                    break;
                default:
                    origen = areaPosteC;
                    break;
            }
            switch (Destino)
            {
                case 'A':
                    destino= areaPosteA;
                    break;
                case 'B':
                    destino = areaPosteB;
                    break;
                default:
                    destino = areaPosteC;
                    break;
            }

            disco = (Panel)origen.Controls[origen.Controls.Count-1];
            origen.Controls.Remove(disco);
            origen.BorderStyle = BorderStyle.None;
            destino.Controls.Add(disco);
        }

        private void CrearDiscos(int numDiscos)
        {
            for (int i = 0; i < numDiscos; i++)
            {
                discos.Push(new Panel()
                {
                    BackColor = Color.RosyBrown,
                    Width = 10 + i * 20,
                    Height = 20,
                    Tag = i,
                    Left = (190 - (10 + i * 20)) / 2,
                    Anchor = AnchorStyles.None,
                    
                });
                discos.Peek().Click += disco_Click;
            }
        }

        private void FrmHanoi_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show(((Panel)sender).Tag.ToString());
        }

        private void disco_Click(object? sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            //MessageBox.Show(p.Parent.Tag.ToString());
           
        }
        System.Windows.Forms.Timer mensaje_Timer;

        private void areaPoste_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            //MessageBox.Show(panel.Tag.ToString()) ;
            if (panelSeleccionado==' ')
            {
                panelSeleccionado = panel.Tag.ToString()[0];
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                char segundo = panel.Tag.ToString()[0];
                try
                {
                    juego.Mover(panelSeleccionado, segundo);
                }
                catch (Exception ex)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = ex.Message;
                    mensaje_Timer=new System.Windows.Forms.Timer();
                    mensaje_Timer.Interval=2000;
                    mensaje_Timer.Tick += Mensaje_Timer_Tick;
                    mensaje_Timer.Start();
                }
                panelSeleccionado = ' ';
            }
        }

        private void Mensaje_Timer_Tick(object? sender, EventArgs e)
        {
            lblMensaje.Text = "";
            mensaje_Timer.Stop();
        }
    }
}