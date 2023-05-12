/*
 * Created by SharpDevelop.
 * User: Vojtech
 * Date: 23.11.2022
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cokoliv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public bool menimDelku = false;
		public bool menimMenu = false;
		public bool menimHmotnost = false;
		public bool menimCas = false;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ClearClick(object sender, EventArgs e)
		{
			kilometruDelkaTextBox.Text = "";
			milDelkaTextBox.Text = "";
			metruDelkaTextBox.Text = "";
			stopDelkaTextBox.Text = "";
			decimetruDelkaTextBox.Text = "";
			palcuDelkaTextBox.Text = "";	
			centimetruDelkatextBox.Text = "";
			milimetruDelkaTextBox.Text = "";
		}

		void MilDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(milDelkaTextBox.Text)) {
				
					isNumerical = double.TryParse(milDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						kilometruDelkaTextBox.Text = (vstup * 1.609344).ToString();
						metruDelkaTextBox.Text = (vstup * 1609.344).ToString();
						stopDelkaTextBox.Text = (vstup * 5280).ToString();
						decimetruDelkaTextBox.Text = (vstup * 16093.44).ToString();
						palcuDelkaTextBox.Text = (vstup * 63360).ToString();
						centimetruDelkatextBox.Text = (vstup * 160934.4).ToString();
						milimetruDelkaTextBox.Text = (vstup * 1609344).ToString();						
					}
				}
				menimDelku=false;
			}		
		}		
		
		void KilometruDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(kilometruDelkaTextBox.Text)) {
				
					isNumerical = double.TryParse(kilometruDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup * 0.6213727).ToString();
						metruDelkaTextBox.Text = (vstup * 1000).ToString();
						stopDelkaTextBox.Text = (vstup * 3280.84).ToString();
						decimetruDelkaTextBox.Text = (vstup * 10000).ToString();
						palcuDelkaTextBox.Text = (vstup * 39370.08).ToString();		
						centimetruDelkatextBox.Text = (vstup * 100000).ToString();
						milimetruDelkaTextBox.Text = (vstup * 1000000).ToString();						
					}
				}
				menimDelku=false;
			}	
		}
		
		void MetruTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(metruDelkaTextBox.Text)) {
					
					isNumerical = double.TryParse(metruDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup / 1609.34).ToString();
						kilometruDelkaTextBox.Text = (vstup / 1000).ToString();
						stopDelkaTextBox.Text = (vstup / 0.3048).ToString();
						decimetruDelkaTextBox.Text = (vstup * 10).ToString();
						palcuDelkaTextBox.Text = (vstup / 0.0254).ToString();	
						centimetruDelkatextBox.Text = (vstup * 100).ToString();						
						milimetruDelkaTextBox.Text = (vstup * 1000).ToString();
					}
				}
				menimDelku=false;
			}
		}
		
		void StopDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;		
				if(!string.IsNullOrEmpty(stopDelkaTextBox.Text)) {
					
					isNumerical = double.TryParse(stopDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup * 0.0001893939).ToString();
						kilometruDelkaTextBox.Text = (vstup / 0.0003048).ToString();
						metruDelkaTextBox.Text = (vstup * 0.3048).ToString();
						decimetruDelkaTextBox.Text = (vstup * 3.048).ToString();	
						palcuDelkaTextBox.Text = (vstup * 12).ToString();	
						centimetruDelkatextBox.Text = (vstup * 30.48).ToString();
						milimetruDelkaTextBox.Text = (vstup * 304.8).ToString();						
					}
				}
				menimDelku=false;
			}		
		}
		
		void DecimetruDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(decimetruDelkaTextBox.Text)) {
					
					isNumerical = double.TryParse(decimetruDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup * 0.00006214).ToString();
						kilometruDelkaTextBox.Text = (vstup / 10000).ToString();
						metruDelkaTextBox.Text = (vstup / 10).ToString();
						stopDelkaTextBox.Text = (vstup * 0.328084).ToString();
						palcuDelkaTextBox.Text = (vstup * 3.9370079).ToString();
						centimetruDelkatextBox.Text = (vstup * 10).ToString();						
						milimetruDelkaTextBox.Text = (vstup * 100).ToString();						
					}
				}
				menimDelku=false;
			}				
		}
		
		void PalcuDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;

			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(palcuDelkaTextBox.Text)) {
					isNumerical = double.TryParse(palcuDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup * 0.00001578).ToString();
						kilometruDelkaTextBox.Text = (vstup * 0.0000254).ToString();						
						metruDelkaTextBox.Text = (vstup * 0.0254).ToString();
						stopDelkaTextBox.Text = (vstup * 0.0833333).ToString();
						decimetruDelkaTextBox.Text = (vstup * 0.254).ToString();
						centimetruDelkatextBox.Text = (vstup * 2.54).ToString();												
						milimetruDelkaTextBox.Text = (vstup * 25.4).ToString();						
					}
				}
				menimDelku=false;
			}
		}
		
		void centimetruDelkaTextBoxChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(centimetruDelkatextBox.Text)) {
					
					isNumerical = double.TryParse(centimetruDelkatextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup * 0.000006214).ToString();
						kilometruDelkaTextBox.Text = (vstup / 100000).ToString();						
						metruDelkaTextBox.Text = (vstup / 100).ToString();
						stopDelkaTextBox.Text = (vstup * 0.0328084).ToString();
						decimetruDelkaTextBox.Text = (vstup / 10).ToString();
						palcuDelkaTextBox.Text = (vstup * 0.3937008).ToString();						
						milimetruDelkaTextBox.Text = (vstup * 10).ToString();						
					}
				}
				menimDelku=false;
			}				
		}		
		
		void MilimetruDelkaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimDelku) {
				menimDelku=true;
				if(!string.IsNullOrEmpty(milimetruDelkaTextBox.Text)) {
					
					isNumerical = double.TryParse(milimetruDelkaTextBox.Text, out vstup);
					if(isNumerical) {
						milDelkaTextBox.Text = (vstup / 1609340).ToString();
						kilometruDelkaTextBox.Text = (vstup / 1000000).ToString();
						metruDelkaTextBox.Text = (vstup / 1000).ToString();
						stopDelkaTextBox.Text = (vstup / 304.8).ToString();
						decimetruDelkaTextBox.Text = (vstup / 100).ToString();
						palcuDelkaTextBox.Text = (vstup / 25.4).ToString();	
						centimetruDelkatextBox.Text = (vstup / 10).ToString();						
					}
				}
				menimDelku=false;
			}				
		}
		void ClearMenaClick(object sender, EventArgs e)
		{
			korunaMenaTextBox.Text = "";
			eurMenaTextBox.Text = "";
			dolaruMenaTextBox.Text = "";
			liberMenaTextBox.Text = "";
			kunMenaTextBox.Text = "";
			forintuMenaTextBox.Text = "";	
			zlotychMenaTextBox.Text = "";
			bahtThajskyMenaTextBox.Text = "";
		}
		void KorunaMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(korunaMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(korunaMenaTextBox.Text, out vstup);
					if(isNumerical) {
						eurMenaTextBox.Text = (vstup * 0.0416233).ToString();
						dolaruMenaTextBox.Text = (vstup * 0.0441073).ToString();
						liberMenaTextBox.Text = (vstup * 0.0366623).ToString();
						kunMenaTextBox.Text = (vstup * 0.3125).ToString();
						forintuMenaTextBox.Text = (vstup * 16.4771791).ToString();
						zlotychMenaTextBox.Text = (vstup * 0.1942879).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 1.500195).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void EurMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(eurMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(eurMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 24.025).ToString();
						dolaruMenaTextBox.Text = (vstup * 1.0596771).ToString();
						liberMenaTextBox.Text = (vstup * 0.880811).ToString();
						kunMenaTextBox.Text = (vstup * 7.5078125).ToString();
						forintuMenaTextBox.Text = (vstup * 395.864228).ToString();
						zlotychMenaTextBox.Text = (vstup * 4.6677676).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 36.0421855).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void DolaruMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(dolaruMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(dolaruMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 22.676).ToString();
						eurMenaTextBox.Text = (vstup * 0.9436538).ToString();
						liberMenaTextBox.Text = (vstup * 0.8331251).ToString();
						kunMenaTextBox.Text = (vstup * 7.08625).ToString();
						forintuMenaTextBox.Text = (vstup * 374.6241533).ToString();
						zlotychMenaTextBox.Text = (vstup * 4.4065293).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 33.9227478).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void LiberMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(liberMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(liberMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 27.218).ToString();
						eurMenaTextBox.Text = (vstup * 1.1326675).ToString();
						dolaruMenaTextBox.Text = (vstup * 1.2002999).ToString();
						kunMenaTextBox.Text = (vstup * 8.505625).ToString();
						forintuMenaTextBox.Text = (vstup * 449.661325).ToString();
						zlotychMenaTextBox.Text = (vstup * 5.2891566).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 40.71747).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void KunMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(kunMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(kunMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 3.2).ToString();
						eurMenaTextBox.Text = (vstup * 0.1331669).ToString();
						dolaruMenaTextBox.Text = (vstup * 0.1411184).ToString();
						liberMenaTextBox.Text = (vstup * 0.1175693).ToString();
						forintuMenaTextBox.Text = (vstup * 52.8663473).ToString();
						zlotychMenaTextBox.Text = (vstup * 0.6218422).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 4.7871226).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void ForintuMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(forintuMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(forintuMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 0.06053).ToString();
						eurMenaTextBox.Text = (vstup * 0.0025189).ToString();
						dolaruMenaTextBox.Text = (vstup * 0.0026693).ToString();
						liberMenaTextBox.Text = (vstup * 0.0022239).ToString();
						kunMenaTextBox.Text = (vstup * 0.0189156).ToString();
						zlotychMenaTextBox.Text = (vstup * 0.0117625).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 0.0905514).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void ZlotychMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(zlotychMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(zlotychMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 5.146).ToString();
						eurMenaTextBox.Text = (vstup * 0.214149).ToString();
						dolaruMenaTextBox.Text = (vstup * 0.226936).ToString();
						liberMenaTextBox.Text = (vstup * 0.1890661).ToString();
						kunMenaTextBox.Text = (vstup * 1.608125).ToString();
						forintuMenaTextBox.Text = (vstup * 85.0156947).ToString();	
						bahtThajskyMenaTextBox.Text = (vstup * 7.6982916).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		void BahtThajskyMenaTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimMenu) {
				menimMenu=true;				
				if(!string.IsNullOrEmpty(bahtThajskyMenaTextBox.Text)) {
					
					isNumerical = double.TryParse(bahtThajskyMenaTextBox.Text, out vstup);
					if(isNumerical) {
						korunaMenaTextBox.Text = (vstup * 0.66846).ToString();
						eurMenaTextBox.Text = (vstup * 0.0278177).ToString();
						dolaruMenaTextBox.Text = (vstup * 0.0294787).ToString();
						liberMenaTextBox.Text = (vstup * 0.0245595).ToString();
						kunMenaTextBox.Text = (vstup * 0.2088938).ToString();
						forintuMenaTextBox.Text = (vstup * 11.0434495).ToString();	
						zlotychMenaTextBox.Text = (vstup * 0.129899).ToString();						
					}
				}
				menimMenu=false;
			}
		}
		
		void ClearHmotnostClick(object sender, EventArgs e)
		{
			kilogramHmotnostTextBox.Text = "";
			gramHmotnostTextBox.Text = "";
			liberHmotnostTextBox.Text = "";
			tunHmotnostTextBox.Text = "";
			dekagramuHmotnostTextBox.Text = "";
			miligramuHmotnostTextBox.Text = "";
			metrickychCentuHmotnostTextBox.Text = "";
			unciHmotnostTextBox.Text = "";
		}
		
		void KilogramHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(kilogramHmotnostTextBox.Text)) {
				
					isNumerical = double.TryParse(kilogramHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						gramHmotnostTextBox.Text = (vstup * 1000).ToString();
						liberHmotnostTextBox.Text = (vstup * 2.2046244).ToString();
						tunHmotnostTextBox.Text = (vstup * 0.001).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 100).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 1000000).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup * 0.01).ToString();
						unciHmotnostTextBox.Text = (vstup * 35.2739907).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void GramHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(gramHmotnostTextBox.Text)) {
				
					isNumerical = double.TryParse(gramHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup * 0.001).ToString();
						liberHmotnostTextBox.Text = (vstup * 0.0022046).ToString();
						tunHmotnostTextBox.Text = (vstup / 1000000).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 0.1).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 1000).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup / 100000).ToString();
						unciHmotnostTextBox.Text = (vstup * 0.035274).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void LiberHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(liberHmotnostTextBox.Text)) {
				
					isNumerical = double.TryParse(liberHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup * 0.453592).ToString();
						gramHmotnostTextBox.Text = (vstup * 453.592).ToString();
						tunHmotnostTextBox.Text = (vstup * 0.0004536).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 45.3592).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 453592).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup * 0.0045359).ToString();
						unciHmotnostTextBox.Text = (vstup * 16).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void TunHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(tunHmotnostTextBox.Text)) {
				
					isNumerical = double.TryParse(tunHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup * 1000).ToString();
						gramHmotnostTextBox.Text = (vstup * 1000000).ToString();
						liberHmotnostTextBox.Text = (vstup * 2204.62).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 100000).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 1000000000).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup * 10).ToString();
						unciHmotnostTextBox.Text = (vstup * 35273.99).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void DekagramuHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(dekagramuHmotnostTextBox.Text)) {
				
					isNumerical = double.TryParse(dekagramuHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup * 0.01).ToString();
						gramHmotnostTextBox.Text = (vstup * 10).ToString();
						liberHmotnostTextBox.Text = (vstup * 0.0220462).ToString();
						tunHmotnostTextBox.Text = (vstup / 100000).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 10000).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup / 10000).ToString();
						unciHmotnostTextBox.Text = (vstup * 0.3527399).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void MiligramuHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(miligramuHmotnostTextBox .Text)) {
				
					isNumerical = double.TryParse(miligramuHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup / 1000000).ToString();
						gramHmotnostTextBox.Text = (vstup * 0.001).ToString();
						liberHmotnostTextBox.Text = (vstup * 0.000002205).ToString();
						tunHmotnostTextBox.Text = (vstup / 1000000000).ToString();
						dekagramuHmotnostTextBox.Text = (vstup / 10000).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup / 100000000).ToString();
						unciHmotnostTextBox.Text = (vstup * 0.00003527).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void MetrickychCentuHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(metrickychCentuHmotnostTextBox .Text)) {
				
					isNumerical = double.TryParse(metrickychCentuHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						kilogramHmotnostTextBox.Text = (vstup * 100).ToString();
						gramHmotnostTextBox.Text = (vstup * 100000).ToString();
						liberHmotnostTextBox.Text = (vstup * 220.462442).ToString();
						tunHmotnostTextBox.Text = (vstup * 0.1).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 10000).ToString();
						miligramuHmotnostTextBox.Text = (vstup * 100000000).ToString();
						unciHmotnostTextBox.Text = (vstup * 3527.4).ToString();						
					}
				}
				menimHmotnost=false;
			}
		}
		void ClearCasClick(object sender, EventArgs e)
		{
			sekundaCasTextBox.Text = "";
			minutCasTextBox.Text = "";
			hodinCasTextBox.Text = "";
			dniCasTextBox.Text = "";
			mesicuCasTextBox.Text = "";
			milisekundCasTextBox.Text = "";
			tydnuCasTextBox.Text = "";
			gregorianskyRokCasTextBox.Text = "";
		}
		void SekundaCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(sekundaCasTextBox .Text)) {
				
					isNumerical = double.TryParse(sekundaCasTextBox.Text, out vstup);
					if(isNumerical) {
						minutCasTextBox.Text = (vstup * 0.0166667).ToString();
						hodinCasTextBox.Text = (vstup * 0.0002778).ToString();
						dniCasTextBox.Text = (vstup * 0.00001157).ToString();
						mesicuCasTextBox.Text = (vstup * 0.0000003803).ToString();
						milisekundCasTextBox.Text = (vstup * 1000).ToString();
						tydnuCasTextBox.Text = (vstup * 0.000001653).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.00000003169).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void MinutCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(minutCasTextBox .Text)) {
				
					isNumerical = double.TryParse(minutCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 60).ToString();
						hodinCasTextBox.Text = (vstup * 0.0166667).ToString();
						dniCasTextBox.Text = (vstup * 0.0006944).ToString();
						mesicuCasTextBox.Text = (vstup * 0.00002282).ToString();
						milisekundCasTextBox.Text = (vstup * 60000).ToString();
						tydnuCasTextBox.Text = (vstup * 0.00009921).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.000001901).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void HodinCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(hodinCasTextBox .Text)) {
				
					isNumerical = double.TryParse(hodinCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 3600).ToString();
						minutCasTextBox.Text = (vstup * 60).ToString();
						dniCasTextBox.Text = (vstup * 0.0416667).ToString();
						mesicuCasTextBox.Text = (vstup * 0.0013689).ToString();
						milisekundCasTextBox.Text = (vstup * 3600000).ToString();
						tydnuCasTextBox.Text = (vstup * 0.0059524).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.0001141).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void DniCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(dniCasTextBox .Text)) {
				
					isNumerical = double.TryParse(dniCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 86400).ToString();
						minutCasTextBox.Text = (vstup * 1440).ToString();
						hodinCasTextBox.Text = (vstup * 24).ToString();
						mesicuCasTextBox.Text = (vstup * 0.0328542).ToString();
						milisekundCasTextBox.Text = (vstup * 86400000).ToString();
						tydnuCasTextBox.Text = (vstup * 0.1428571).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.0027379).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void MesicuCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(mesicuCasTextBox .Text)) {
				
					isNumerical = double.TryParse(mesicuCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 2629800).ToString();
						minutCasTextBox.Text = (vstup * 43830).ToString();
						hodinCasTextBox.Text = (vstup * 730.5).ToString();
						dniCasTextBox.Text = (vstup * 30.4375).ToString();
						milisekundCasTextBox.Text = (vstup * 2630000000).ToString();
						tydnuCasTextBox.Text = (vstup * 4.3482143).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.0833349).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void MilisekundCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(milisekundCasTextBox .Text)) {
				
					isNumerical = double.TryParse(milisekundCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 0.001).ToString();
						minutCasTextBox.Text = (vstup * 0.00001667).ToString();
						hodinCasTextBox.Text = (vstup * 0.0000002778).ToString();
						dniCasTextBox.Text = (vstup * 0.00000001157).ToString();
						mesicuCasTextBox.Text = (vstup * 0.0000000003803).ToString();
						tydnuCasTextBox.Text = (vstup * 0.000000001653).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.00000000003169).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void TydnuCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(tydnuCasTextBox .Text)) {
				
					isNumerical = double.TryParse(tydnuCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 604800).ToString();
						minutCasTextBox.Text = (vstup * 10080).ToString();
						hodinCasTextBox.Text = (vstup * 168).ToString();
						dniCasTextBox.Text = (vstup * 7).ToString();
						mesicuCasTextBox.Text = (vstup * 0.2299795).ToString();
						milisekundCasTextBox.Text = (vstup * 604800000).ToString();						
						gregorianskyRokCasTextBox.Text = (vstup * 0.0191653).ToString();						
					}
				}
				menimCas=false;
			}
		}
		void GregorianskyRokCasTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimCas) {
				menimCas=true;
				if(!string.IsNullOrEmpty(gregorianskyRokCasTextBox .Text)) {
				
					isNumerical = double.TryParse(gregorianskyRokCasTextBox.Text, out vstup);
					if(isNumerical) {
						sekundaCasTextBox.Text = (vstup * 31557000).ToString();
						minutCasTextBox.Text = (vstup * 525950).ToString();
						hodinCasTextBox.Text = (vstup * 8765.83).ToString();
						dniCasTextBox.Text = (vstup * 365.2430556).ToString();
						mesicuCasTextBox.Text = (vstup * 11.9997718).ToString();
						milisekundCasTextBox.Text = (vstup * 31560000000 ).ToString();						
						tydnuCasTextBox.Text = (vstup * 52.1775794).ToString();
					}
				}
				menimCas=false;
			}
		}
		void UnciHmotnostTextBoxTextChanged(object sender, EventArgs e)
		{
			double vstup;
			bool isNumerical;
			
			if(!menimHmotnost) {
				menimHmotnost=true;
				if(!string.IsNullOrEmpty(unciHmotnostTextBox .Text)) {
				
					isNumerical = double.TryParse(unciHmotnostTextBox.Text, out vstup);
					if(isNumerical) {
						tunHmotnostTextBox.Text = (vstup * 0.00002835).ToString();
						kilogramHmotnostTextBox.Text = (vstup * 0.0283495).ToString();
						gramHmotnostTextBox.Text = (vstup * 28.3495).ToString();
						liberHmotnostTextBox.Text = (vstup * 0.0625).ToString();
						dekagramuHmotnostTextBox.Text = (vstup * 2.83495).ToString();
						metrickychCentuHmotnostTextBox.Text = (vstup * 0.0002835 ).ToString();						
						miligramuHmotnostTextBox.Text = (vstup * 28349.5).ToString();
					}
				}
				menimHmotnost=false;
			}
		}
		
	}
}
