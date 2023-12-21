NINJATRADER BASIC TEMPLATE / CHEATSHEET:

	a.1.0 public class <MY INDICATOR> : Indicator
	
		a.A.1.0 CLASS VARIABLES
				private bool doOnce = false;
				private bool Is_ToolBar_Controls_Added;
				
				private Account	myAccount;
				
				private Position	accountPosition;
				
				private double	currentPTPrice, currentSLPrice;
				
				private Order	entryBuyMarketOrder1stOrdersGroup;
				
				private List<Order>	multiOrders;
				
				private Chart	chartWindow;
				
				private int	 qs;
				
				private TextBox	 quantitySelectorTextBox;
		
		a.B.1.0 ON STATE CHANGE 
		protected override void OnStateChange()
		
			b.2.0 (State == State.SetDefaults)
					UseStopLoss					= true; 				// bool
					StopLossMove				= 1; 					// int
					AccountName 				= "Sim101"; 			// string
					AddPlot(
						new Stroke(
							Brushes.Magenta,	5), 
							PlotStyle.Hash, 
							"CombinedVolume"							// Series<double>
							);											// plot
					LineColor					= Brushes.White;		// Brush
					IsOverlay					= false;
					IsSuspendedWhileInactive	= false;
					DrawOnPricePanel			= false;
					Calculate					= Calculate.OnBarClose; //OnEachTick//EnPriceChange
					
			b.2.1 (State == State.Configure)
					AddDataSeries
					
			b.2.2 (State == State.Historical)
					SetZOrder
				    (!Is_ToolBar_Controls_Added) Add_Controls_To_Toolbar();
					(Calculate == Calculate.OnPriceChange)
					
			b.2.3 (State == State.DataLoaded)
					(Account.All)
					(myAccount != null)
					(ChartControl != null)
					multiOrders	= new List<Order>();
					
			b.2.4 (State == State.Terminated)
					(myAccount != null)
					(ChartControl != null)
					
		(a.C.1.0 MAIN: OPTIONAL METHODS)
			private void Add_Controls_To_Toolbar()
			private void DeleteBackspace_quantitySelector_PreviewKeyDown(object sender, KeyEventArgs p)
			private async void OnPreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs p)
			protected void ChartControl_PreviewKeyDown(object sender, KeyEventArgs e)
			private async void Account_OrderUpdate(object sender, OrderEventArgs orderUpdateArgs)
			
		a.D.1.0 ON BAR UPDATE 
		protected override void OnBarUpdate()
			d.2.0 CHECKS
				  (CurrentBars[0] <= 55)
				  (BarsInProgress == 0)
			d.2.1 CALLED METHODS	  
				  MYCALLABLEMETHODA() //OPTIONAL
				  MYCALLABLEMETHODB() //OPTIONAL
				  
		a.E.1.0 CALLABLE METHODS (FOR OnBarUpdate())
					protected void MYCALLABLEMETHODA()
					protected void MYCALLABLEMETHODB()
			
		(a.C.1.0 BIS: OPTIONAL METHODS)
			private void DisposeCleanUp()
		
		a.F.1.0 PROPERTIES
			f.2.0 BOOL
			f.2.1 INT
			f.2.2 DOUBLE
			f.2.3 DATETIME
			f.2.4 STRING
			f.2.5 TIMESPAN
			f.2.6 DATETIME UNDOCUMMENTED
			f.2.7 BRUSH
			f.2.8 DASHHELPER STYLE
			
		a.G.1.0 EXTRA CLASSES
			d.1.0 public class <MY EXTRA CLASS> : TypeConverter
		
		a.H.1.0 NINJASCRIPT GENERATED CODE


#region HOTKEYS

	HOTKEY FOR COMMENTING UNCOMMENTING
	HOTKEY FOR COMMENTING / UNCOMMENTING ALL PRINTS STATEMENTS
	HOTKEY FOR #region #endregion
	
#endregion

#region F2 BOILERPLATES COMMANDS ADDITIONS:

	#region BOOL FLAGS:

		#region SCOPE: CLASS | doOnce Bool Flag Class Scope Variables
		
			private bool doOnce = false; 
		
		#endregion

		#region SCOPE: OnBarUpdate() ACTION BLOCK — SUB-SCOPE: IF STATEMENT CONDITION BLOCK |  SET  doOnce Bool Flag 
			if (<YOUR CONDITIONS HERE>
				&& (doOnce == false) )
			{
				doOnce = true;
			}
		#endregion

				
		#region SCOPE: OnBarUpdate() ACTION BLOCK — SUB-SCOPE: IF STATEMENT ACTION BLOCK |  RESET doOnce Bool Flag 
			
			if (IsFirstTickOfBar)
			{
				doOnce = false;
			}
				
		#endregion

	#endregion


	#region BOOL SWITCHES:

		#region SCOPE: (State == State.SetDefaults) ACTION BLOCK
		
			#region Bars Sounds Bool Switches
			
				HSoundSwitch					= true;
				IHSounsSwitch					= true;
			
			#endregion
		
		#endregion
		
		
		#region SCOPE: OnBarUpdate() ACTION BLOCK

			#region SUB-SCOPE : <YOUR MAIN CONDITION(s) STATEMENT>			
			
				if ( <YOUR MAIN CONDITION(s) STATEMENT>
					&& (doOnce == false) )
				{
					if(HSoundSwitch)
					{
						PlaySound(@"C:\Program Files\NinjaTrader 8\sounds\" + SoundFilesHBrush);
						
						doOnce = true; // prevent additional alerts
					}
				}
		
			#endregion

			#region SUB-SCOPE : <YOUR MAIN CONDITION(s) STATEMENT>			
			
				else if ( <YOUR REVERSE MAIN CONDITION(s) STATEMENT>
						&& (doOnce == false) )
				{
					if(IHSounsSwitch)
					{
						PlaySound(@"C:\Program Files\NinjaTrader 8\sounds\" + SoundFilesIHBrush);
						
						doOnce = true; // prevent additional alerts
					}
				}
		
			#endregion
		
		#endregion
		
		
		#region SCOPE : Properties BLOCK

			#region 00. Sounds Switch On/Off
			
				[NinjaScriptProperty]
				[Display(Name="Hammer Sound Switch On/Off", Order=1, GroupName="00. Sounds Switch On/Off")]
				public bool HSoundSwitch
				{ get; set; }
			
				[NinjaScriptProperty]
				[Display(Name="Inverted Hammer Sound Switch On/Off", Order=2, GroupName="00. Sounds Switch On/Off")]
				public bool IHSounsSwitch
				{ get; set; }
			
			#endregion
			
		#endregion
		
	#endregion


	#region PRINTS (ideally highlight and click creaste prints)

		bool allCONDITIONS = (  ( CONDITION 0 )
				&& ( CONDITION 1 )
				&& ( CONDITION 2 )
				&& ( CONDITION 3 )
				&& ( CONDITION 4 )  );
		Print("( CONDITION 0 ) : " + ( CONDITION 0 ) + " Time[0] : " + Time[0] );
		Print("( CONDITION 0 ) : " + ( CONDITION 1 ) );
		Print("( CONDITION 0 ) : " + ( CONDITION 2 ) );
		Print("( CONDITION 0 ) : " + ( CONDITION 3 ) );
		Print("( CONDITION 0 ) : " + ( CONDITION 4 ) );
		Print("( allCONDITIONS ) : " + ( allCONDITIONS ) );
		
		if (allCONDITIONS)
		{
			// <YOUR ACTION(S) HERE.>
		}
		
	#endregion


	#region PROPERTIES SECTION

		properties:
		
			c.2.0 BOOL
			c.2.1 INT
			c.2.2 DOUBLE
			c.2.3 DATETIME
			c.2.4 STRING
			c.2.5 TIMESPAN
			c.2.6 DATETIME UNDOCUMMENTED
			c.2.7 BRUSH
			c.2.8 DASHHELPER STYLE
			

		#region SCOPE : Properties

			#region 00. BOOL
			
				[NinjaScriptProperty]
				[
					Display(
							Name="YOUR NAME HERE", 
							Description = "YOUR DESCRIPTION HERE", 
							Order=1, 
							GroupName="YOUR GROUP NAME HERE"
						)
				]
				public bool SqueezePOCBoolDwn
				{ get; set; }
				
			#endregion
			
			#region 01. INT

				[NinjaScriptProperty]
				[Range(1, int.MaxValue)]
				[
				 Display(Name = "YOUR NAME HERE", 
				 Description = "YOUR DESCRIPTION HERE", 
				 Order = 1, 
				 GroupName = "YOUR GROUP NAME HERE")
				]
				public int StartDisplay
				{ get; set; }
				
			#endregion
						
			#region 02. DOUBLE
			
				[Browsable(false)]
				[XmlIgnore()]
				public Series<double> CombinedVolume
				{
					get { return Values[0]; }
				}
				
			#endregion	
			
			#region 03. STRING

				[NinjaScriptProperty]
				[
					Display(
							Name="YOUR NAME HERE", 
							Description = "YOUR DESCRIPTION HERE", 
							Order=1, 
							GroupName="YOUR GROUP NAME HERE"
						)
				]
				[TypeConverter(typeof(NinjaTrader.NinjaScript.Indicators.SoundConverter))] 
				public string SoundFilesSqueezePOCDwn
				{get;set;}
				
			#endregion
			
			#region 04. DATETIME

				[NinjaScriptProperty]
				[
				 Display(
						 ResourceType = typeof(Custom.Resource), 
						 Name="PreSessionStart", 
						 Description="Opening time of pre-session", 
						 Order=1, 
						 GroupName="NinjaScriptStrategyParameters"
						)
				]
				public DateTime PreSessionStart
				{ get; set; }
				
			#endregion
			
			#region 05. TIMESPAN
				
				[NinjaScriptProperty]
				[
				 Display(
						 ResourceType = typeof(Custom.Resource), 
						 Name="MyTime", 
						 Description="MyTime", 
						 Order=1, 
						 GroupName="NinjaScriptStrategyParameters"
						 )
				]
				public TimeSpan MyTime
				{ get; set; }
				
			#endregion
			
			#region 06. DATETIME UNDOCUMMENTED
			
				[Gui.PropertyEditor("NinjaTrader.Gui.Tools.TimeEditorKey")]
				public DateTime MyTime 
				{get; set;}
				
			#endregion
			
			#region 07. BRUSH	
		
				[NinjaScriptProperty]
				[XmlIgnore]
				[
				 Display(
						 Name="Long Color", 
						 Order=4, 
						 GroupName="View"
						)
				]
				public Brush BuyClr
				{ get; set; }

				[Browsable(false)]
				public string BuyClrSerializable
				{
					get { return Serialize.BrushToString(BuyClr); }
					set { BuyClr = Serialize.StringToBrush(value); }
				}
				
			#endregion	
			
			#region 08. DASHHELPER STYLE		
		
				[NinjaScriptProperty]
				[
				 Display(
				 Name="Line's Style", 
				 Order=7, 
				 GroupName="View")
				]
				public DashStyleHelper eStyle
				{ get; set; }
				
			#endregion
				
		#endregion

	#endregion

#endregion


#region MULTIPLE DATA SERIES

	// ON A 1MIN CHART
	
	(State == State.Configure)
	{
		AddDataSeries(BarsPeriodType.Tick, 1);
		AddDataSeries(BarsPeriodType.Minute, 60);
	}
	protected override void OnBarUpdate()
	{
		Closes[0][0] // 1MIN DATA SERIES
		Closes[1][0] // 1 TICK DATA SERIES
		Closes[2][0] // 60MIN DATA SERIES
	}

#endregion


#region REQUEST

	LIST OF FEATURES REQUEST, IN A TABLE FORMAT FREELY ACCESSIBLE TO USER
	TO VOTE.
	fEATURE TITLE WITH HYPERLINK |	# VOTES	| VOTE BUTTON (SIMILAR TO LIKES BUTTON IN THE FORUM > 1 USER = 1 VOTE MAX)
	

#endregion