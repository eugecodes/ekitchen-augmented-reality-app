using UnityEngine;
using System.Collections;

public class varraDEVIDA : MonoBehaviour {
	public GUIStyle barradevida;
	public Texture2D imagenFondo;
	public Texture2D imagenFrente;
	public float vida = 256f;
	public void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.gameObject.tag == "velociraptoryes"); 
			}

	//se ejecuta cada intante del juego
	void OnGUI(){
                		GUI.BeginGroup (new Rect(0,0,390,32));
		GUI.Box(new Rect(0,0,390,35),imagenFondo,barradevida);

		GUI.BeginGroup (new Rect(0,0,vida*256,32));
		GUI.Box(new Rect(0,0,230,35),imagenFrente,barradevida);

		GUI.EndGroup ();
		GUI.EndGroup ();
	}

	void OnTriggerEnter3D()
	{   //Collider.GameObject.tag == "velociraptoryes"
		//if (Collider.gameObject == "velociraptoryes") {}
			//{
			//vida -= 1f;
			//	print ("hit");}
	//
		//{
		//	if (vida <= 0)
		//		vida = 0;
		//	Debug.Log ("You are Dead");}
		 //}

}	}	