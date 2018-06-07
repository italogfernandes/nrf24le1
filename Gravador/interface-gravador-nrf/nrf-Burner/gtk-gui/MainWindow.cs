
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action closeAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action helpAction;
	
	private global::Gtk.Action aboutAction;
	
	private global::Gtk.Action refreshAction;
	
	private global::Gtk.Action dialogInfoAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Button btn_erase;
	
	private global::Gtk.Button btn_exit_prog;
	
	private global::Gtk.Button btn_iniciar;
	
	private global::Gtk.Button btn_prog_mode;
	
	private global::Gtk.Button btn_read_info;
	
	private global::Gtk.Button btn_send_hex;
	
	private global::Gtk.Button btn_verify;
	
	private global::Gtk.Button btn_write_new;
	
	private global::Gtk.Button btnAutoBurn;
	
	private global::Gtk.Button btnBurn;
	
	private global::Gtk.Button btnConectar;
	
	private global::Gtk.Button btnReadCode;
	
	private global::Gtk.ComboBox cbPortasSeriais;
	
	private global::Gtk.FileChooserButton filechooserbutton1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView logtextview;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.ComboBox combobox2;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView txt_codigo;
	
	private global::Gtk.Statusbar statusbar1;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.Label lbl_status2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("_Open"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Open");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.saveAction, null);
		this.closeAction = new global::Gtk.Action ("closeAction", global::Mono.Unix.Catalog.GetString ("_Close"), null, "gtk-close");
		this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Close");
		w1.Add (this.closeAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("_Help"), null, "gtk-help");
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
		w1.Add (this.helpAction, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("_About"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_About");
		w1.Add (this.aboutAction, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", global::Mono.Unix.Catalog.GetString ("Refresh Serial Ports"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Refresh Serial Ports");
		w1.Add (this.refreshAction, null);
		this.dialogInfoAction = new global::Gtk.Action ("dialogInfoAction", global::Mono.Unix.Catalog.GetString ("Mensagem dos Desenvolvedores"), null, "gtk-dialog-info");
		this.dialogInfoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Mensagem dos Desenvolvedores");
		w1.Add (this.dialogInfoAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-connect", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='closeAction' action='closeAction'/><separator/><menuitem name='refreshAction' action='refreshAction'/></menu><menu name='AboutAction' action='AboutAction'><menuitem name='helpAction' action='helpAction'/><menuitem name='aboutAction' action='aboutAction'/><menuitem name='dialogInfoAction' action='dialogInfoAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Opções:");
		this.vbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.btn_erase = new global::Gtk.Button ();
		this.btn_erase.CanFocus = true;
		this.btn_erase.Name = "btn_erase";
		this.btn_erase.UseUnderline = true;
		this.btn_erase.Label = global::Mono.Unix.Catalog.GetString ("Erase Old Code");
		this.table1.Add (this.btn_erase);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_erase]));
		w4.TopAttach = ((uint)(5));
		w4.BottomAttach = ((uint)(6));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_exit_prog = new global::Gtk.Button ();
		this.btn_exit_prog.CanFocus = true;
		this.btn_exit_prog.Name = "btn_exit_prog";
		this.btn_exit_prog.UseUnderline = true;
		this.btn_exit_prog.Label = global::Mono.Unix.Catalog.GetString ("Exit Prog Mode");
		this.table1.Add (this.btn_exit_prog);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_exit_prog]));
		w5.TopAttach = ((uint)(6));
		w5.BottomAttach = ((uint)(7));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_iniciar = new global::Gtk.Button ();
		this.btn_iniciar.CanFocus = true;
		this.btn_iniciar.Name = "btn_iniciar";
		this.btn_iniciar.UseUnderline = true;
		this.btn_iniciar.Label = global::Mono.Unix.Catalog.GetString ("Iniciar");
		this.table1.Add (this.btn_iniciar);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_iniciar]));
		w6.TopAttach = ((uint)(3));
		w6.BottomAttach = ((uint)(4));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_prog_mode = new global::Gtk.Button ();
		this.btn_prog_mode.CanFocus = true;
		this.btn_prog_mode.Name = "btn_prog_mode";
		this.btn_prog_mode.UseUnderline = true;
		this.btn_prog_mode.Label = global::Mono.Unix.Catalog.GetString ("Prog Mode");
		this.table1.Add (this.btn_prog_mode);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_prog_mode]));
		w7.TopAttach = ((uint)(4));
		w7.BottomAttach = ((uint)(5));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_read_info = new global::Gtk.Button ();
		this.btn_read_info.CanFocus = true;
		this.btn_read_info.Name = "btn_read_info";
		this.btn_read_info.UseUnderline = true;
		this.btn_read_info.Label = global::Mono.Unix.Catalog.GetString ("Ler InfoPage");
		this.table1.Add (this.btn_read_info);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_read_info]));
		w8.TopAttach = ((uint)(4));
		w8.BottomAttach = ((uint)(5));
		w8.LeftAttach = ((uint)(1));
		w8.RightAttach = ((uint)(2));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_send_hex = new global::Gtk.Button ();
		this.btn_send_hex.CanFocus = true;
		this.btn_send_hex.Name = "btn_send_hex";
		this.btn_send_hex.UseUnderline = true;
		this.btn_send_hex.Label = global::Mono.Unix.Catalog.GetString ("Send Hex");
		this.table1.Add (this.btn_send_hex);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_send_hex]));
		w9.TopAttach = ((uint)(3));
		w9.BottomAttach = ((uint)(4));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_verify = new global::Gtk.Button ();
		this.btn_verify.CanFocus = true;
		this.btn_verify.Name = "btn_verify";
		this.btn_verify.UseUnderline = true;
		this.btn_verify.Label = global::Mono.Unix.Catalog.GetString ("Verificar");
		this.table1.Add (this.btn_verify);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_verify]));
		w10.TopAttach = ((uint)(6));
		w10.BottomAttach = ((uint)(7));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btn_write_new = new global::Gtk.Button ();
		this.btn_write_new.CanFocus = true;
		this.btn_write_new.Name = "btn_write_new";
		this.btn_write_new.UseUnderline = true;
		this.btn_write_new.Label = global::Mono.Unix.Catalog.GetString ("Escrever Novo");
		this.table1.Add (this.btn_write_new);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn_write_new]));
		w11.TopAttach = ((uint)(5));
		w11.BottomAttach = ((uint)(6));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnAutoBurn = new global::Gtk.Button ();
		this.btnAutoBurn.CanFocus = true;
		this.btnAutoBurn.Name = "btnAutoBurn";
		this.btnAutoBurn.UseUnderline = true;
		this.btnAutoBurn.Label = global::Mono.Unix.Catalog.GetString ("Auto Burn");
		this.table1.Add (this.btnAutoBurn);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnAutoBurn]));
		w12.TopAttach = ((uint)(2));
		w12.BottomAttach = ((uint)(3));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnBurn = new global::Gtk.Button ();
		this.btnBurn.CanFocus = true;
		this.btnBurn.Name = "btnBurn";
		this.btnBurn.UseUnderline = true;
		this.btnBurn.Label = global::Mono.Unix.Catalog.GetString ("Gravar Código");
		global::Gtk.Image w13 = new global::Gtk.Image ();
		w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-down", global::Gtk.IconSize.Menu);
		this.btnBurn.Image = w13;
		this.table1.Add (this.btnBurn);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnBurn]));
		w14.TopAttach = ((uint)(1));
		w14.BottomAttach = ((uint)(2));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnConectar = new global::Gtk.Button ();
		this.btnConectar.CanFocus = true;
		this.btnConectar.Name = "btnConectar";
		this.btnConectar.UseUnderline = true;
		this.btnConectar.Label = global::Mono.Unix.Catalog.GetString ("Conectar");
		global::Gtk.Image w15 = new global::Gtk.Image ();
		w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-connect", global::Gtk.IconSize.Menu);
		this.btnConectar.Image = w15;
		this.table1.Add (this.btnConectar);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnConectar]));
		w16.LeftAttach = ((uint)(1));
		w16.RightAttach = ((uint)(2));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnReadCode = new global::Gtk.Button ();
		this.btnReadCode.CanFocus = true;
		this.btnReadCode.Name = "btnReadCode";
		this.btnReadCode.UseUnderline = true;
		this.btnReadCode.Label = "Ler Flash";
		this.table1.Add (this.btnReadCode);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnReadCode]));
		w17.TopAttach = ((uint)(2));
		w17.BottomAttach = ((uint)(3));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.cbPortasSeriais = global::Gtk.ComboBox.NewText ();
		this.cbPortasSeriais.Name = "cbPortasSeriais";
		this.table1.Add (this.cbPortasSeriais);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.cbPortasSeriais]));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.filechooserbutton1 = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooserbutton1.Name = "filechooserbutton1";
		this.table1.Add (this.filechooserbutton1);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.filechooserbutton1]));
		w19.TopAttach = ((uint)(1));
		w19.BottomAttach = ((uint)(2));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox3.Add (this.table1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.table1]));
		w20.Position = 0;
		w20.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.logtextview = new global::Gtk.TextView ();
		this.logtextview.Buffer.Text = "Log:";
		this.logtextview.WidthRequest = 393;
		this.logtextview.CanFocus = true;
		this.logtextview.Name = "logtextview";
		this.logtextview.Editable = false;
		this.GtkScrolledWindow1.Add (this.logtextview);
		this.vbox2.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow1]));
		w23.Position = 2;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Dados:");
		this.hbox2.Add (this.label3);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.combobox2 = global::Gtk.ComboBox.NewText ();
		this.combobox2.Name = "combobox2";
		this.hbox2.Add (this.combobox2);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.combobox2]));
		w26.Position = 1;
		this.vbox4.Add (this.hbox2);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txt_codigo = new global::Gtk.TextView ();
		this.txt_codigo.CanFocus = true;
		this.txt_codigo.Name = "txt_codigo";
		this.GtkScrolledWindow.Add (this.txt_codigo);
		this.vbox4.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
		w29.Position = 1;
		this.hbox1.Add (this.vbox4);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
		w30.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w31.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Status:");
		this.statusbar1.Add (this.label5);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.label5]));
		w32.Position = 1;
		w32.Expand = false;
		w32.Fill = false;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.lbl_status2 = new global::Gtk.Label ();
		this.lbl_status2.Name = "lbl_status2";
		this.lbl_status2.LabelProp = global::Mono.Unix.Catalog.GetString ("Status Label");
		this.statusbar1.Add (this.lbl_status2);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.lbl_status2]));
		w33.Position = 2;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w34.PackType = ((global::Gtk.PackType)(1));
		w34.Position = 2;
		w34.Expand = false;
		w34.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 852;
		this.DefaultHeight = 494;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.closeAction.Activated += new global::System.EventHandler (this.OnCloseActionActivated);
		this.helpAction.Activated += new global::System.EventHandler (this.OnHelpActionActivated);
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
		this.dialogInfoAction.Activated += new global::System.EventHandler (this.OnDialogInfoActionActivated);
		this.filechooserbutton1.SelectionChanged += new global::System.EventHandler (this.OnFilechooserbutton1SelectionChanged);
		this.btnReadCode.Clicked += new global::System.EventHandler (this.OnBtnReadCodeClicked);
		this.btnConectar.Clicked += new global::System.EventHandler (this.OnBtnConectarClicked);
		this.btnBurn.Clicked += new global::System.EventHandler (this.OnBtnBurnClicked);
		this.btnAutoBurn.Clicked += new global::System.EventHandler (this.OnBtnAutoBurnClicked);
		this.btn_write_new.Clicked += new global::System.EventHandler (this.OnBtnWriteNewClicked);
		this.btn_verify.Clicked += new global::System.EventHandler (this.OnBtnVerifyClicked);
		this.btn_send_hex.Clicked += new global::System.EventHandler (this.OnBtnSendHexClicked);
		this.btn_read_info.Clicked += new global::System.EventHandler (this.OnBtnReadInfoClicked);
		this.btn_prog_mode.Clicked += new global::System.EventHandler (this.OnBtnProgModeClicked);
		this.btn_iniciar.Clicked += new global::System.EventHandler (this.OnBtnIniciarClicked);
		this.btn_exit_prog.Clicked += new global::System.EventHandler (this.OnBtnExitProgClicked);
		this.btn_erase.Clicked += new global::System.EventHandler (this.OnBtnEraseClicked);
	}
}