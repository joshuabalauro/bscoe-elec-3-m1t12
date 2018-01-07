using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	int level;
	int holder;
	enum Screen {MainMenu, Password, Win};
	Screen currentScreen = Screen.MainMenu;
	string[] level1 = {"lluebt","ung","fenik","iosnop","awsnhaic"};//bullet,gun,knife,poison,chainsaw  
	string[] level2 = {"carpiy","urmerd","enecigod","imohidec","mugginlgs","ginpidpkna"};//piracy,murder,genocide,homicide,smuggling,kidnapping
	string[] level3 = {"sarduhon","zeveulaen","anidi","repoangsi","anldreztisw","napaj"};//honduras,venezuela,india,singapore,switzerland,japan

	// Use this for initialization
	void Start () {
		ShowMainMenu();
	}

	void ShowMainMenu() {
		currentScreen = Screen.MainMenu;
		Terminal.WriteLine("SW2T12");
		Terminal.WriteLine("Which folder do you want to hack?");
		Terminal.WriteLine(" ");
		Terminal.WriteLine("Press 1 for List of Weapon Used");
		Terminal.WriteLine("Press 2 for List of Crime ");
		Terminal.WriteLine("Press 3 for List of Countries");
		Terminal.WriteLine(" ");
		Terminal.WriteLine("Enter your selection:");
		Terminal.WriteLine(" ");
	}

	void OnUserInput(string input) {
		if(input == "menu") {
			Terminal.ClearScreen();
			ShowMainMenu();
		}
		else if(currentScreen == Screen.MainMenu) {
			RunMainMenu(input);
		}
		else if(currentScreen == Screen.Password) {
			Process(input);
		}
	}

	void RunMainMenu(string input) {
		switch (input) {
		case "1":
			level = 1;
			StartGame ();
			break;
		case "2":
			level = 2;
			StartGame ();
			break;
		case "3":
			level = 3;
			StartGame ();
			break;
		case "007":
			Terminal.ClearScreen ();
			Terminal.WriteLine ("Please choose a level, Mr. Bond.");
			break;
		default:
			Terminal.WriteLine (" ");
			Terminal.WriteLine ("Please choose a valid level.");
			break;
		}
	}

	void StartGame() {
		currentScreen = Screen.Password;
		Terminal.ClearScreen();
		Terminal.WriteLine("Level: " + level);
		if(level == 1) {
			holder = Random.Range(0,level1.Length);
			Terminal.WriteLine(level1[holder]);
		}
		else if(level == 2) {
			holder = Random.Range(0,level2.Length);
			Terminal.WriteLine(level2[holder]);
		}
		else if(level == 3) {
			holder = Random.Range(0,level3.Length);
			Terminal.WriteLine(level3[holder]);
		}
		Terminal.WriteLine("Enter password:");
	}

	void Process(string input) {
		if(level == 1) {
			if(holder == 0) {
				if(input == "bullet") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 1) {
				if(input == "gun") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 2) {
				if(input == "knife") {
					EndGame(input);
				}
			
				else{
					StartGame();
				}
			}
			if(holder == 3) {
				if(input == "poison") {
					EndGame(input);
				}

				else{
					StartGame();
				}
			}
			if(holder == 4) {
				if(input == "chainsaw") {
					EndGame(input);
				}

				else{
					StartGame();
				}
			}
		}
		else if(level == 2) {
			if(holder == 0) {
				if(input == "piracy") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 1) {
				if(input == "murder") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 2) {
				if(input == "genocide") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 3) {
				if(input == "homicide") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 4) {
				if(input == "smuggling") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 5) {
				if(input == "kidnapping") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
		}
		else if(level == 3) {
			if(holder == 0) {
				if(input == "honduras") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 1) {
				if(input == "venezuela") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 2) {
				if(input == "india") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 3) {
				if(input == "singapore") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 4) {
				if(input == "switzerland") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
			if(holder == 5) {
				if(input == "japan") {
					EndGame(input);
				}
				else{
					StartGame();
				}
			}
		}
		else{
			Terminal.WriteLine(" ");
			Terminal.WriteLine("Please input a valid option");
		}
	}

	void EndGame(string input) {
		currentScreen = Screen.Win;
		Terminal.ClearScreen();
		Terminal.WriteLine("You successfully hacked into the folder");
		switch (input) {
		case "bullet":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Sniper bullets can travel so far that the rotation of the Earth will move the target " +
				",and shooters have to adjust their aim accordingly");
			break;
		case "gun":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("The gatling gun wan invented by a doctor who noticed that the majority of soldiers died in the " +
			"civil war due to disease not gun shot wounds");
			break;
		case "knife":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Jagdkommando Tri-Dagger : Deadliest knife ever. It takes a team of surgeon to seal the wound.");
			break;
		case "poison":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("There's a tree that's so poisonous, rainwater dripping off it's leaves will burn your skin. " +
				"It's called Machineel");
			break;
		case "chainsaw":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Chainsaw were originally created as a tool to help deliver babies");
			break;
		case "piracy":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("An Anti-Piracy Ad was fined for using stolen music");
			break;
		case "murder":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("In 1386, a pig in France was executed by public hanging for a murder of a child");
			break;
		case "genocide":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Atleast 1.1 million Jewish children were murder during the holocaust");
			break;
		case "homicide":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("63% of boys ages 11-20 who commit murder kill the man who is abusing their mother");
			break;
		case "smuggling":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Colombian drug cartels have custom-designed fibreglass submarines to smuggle cocaine." +
				"They're designed to carry about 4 people and are extremely hard to detect");
			break;
		case "kidnapping":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("In 2009, a man who was an anti-kidnapping expert in Mexico was kidnapped in Mexico after giving " +
				"a lecture on 'How to not be kidnapped in Mexico'");
			break;
		case "honduras":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Honduras is the highest homicide rate in the entire world");
			break;
		case "venezuela":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Crime in Venezuela is widespread, with violent crimes such as murder and kidnapping often increasing annually");
			break;
		case "india":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("India is the third-most targeted country for phishing attacks after the US and UK");
			break;
		case "singapore":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Most crimes nowadays in Singapore originate from scams that are overseas such as internet scams");
			break;
		case "switzerland":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Switzerland is the lowest homicide rate in the entire world");
			break;
		case "japan":
			Terminal.WriteLine ("Did you know: ");
			Terminal.WriteLine ("Japan has the largest organised crime group in the world called Yamaguchi Gumi that is worth $80bn." +
				"By contrast, Sinalao, Mexico's largest drug cartel, was worth $3bn");
			break;
		}
		Terminal.WriteLine(" ");
		Terminal.WriteLine("Type 'menu' to go back to the main menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
