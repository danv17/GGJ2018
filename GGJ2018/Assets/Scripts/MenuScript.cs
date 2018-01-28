using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas instrucMenu;
	//public Button startText;
	//public Button exitText;

	// Use this for initialization
	void Start () 
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		//startText = startText.GetComponent<Button> ();
		//exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		instrucMenu.enabled = false;
	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		//startText.enabled = false;
		//exitText.enabled = false;
		instrucMenu.enabled = false;
	}
	public void InstPress()
	{
		instrucMenu.enabled = true;
		quitMenu.enabled = false;
		//startText.enabled = false;
		//exitText.enabled = false;

	}
	public void NoPress()
	{
		quitMenu.enabled = false;
		//startText.enabled = true;
		//exitText.enabled = true;
		instrucMenu.enabled = false;
	}
	public void StartLevel()
	{
		SceneManager.LoadScene ("mainScene");
	}
	public void ExitGame()
	{
		Application.Quit ();
	}

}


