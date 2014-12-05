using UnityEngine;
using System.Collections;

public class TrigerBoton : MonoBehaviour {
	//Declaramos los game object Boton y Ascensor y dos variables del tipo Animation, una para cada uno.
		[SerializeField]
		private GameObject Boton;
		[SerializeField]
		private GameObject Ascensor;
		private Animation AnimacionBoton;
		private Animation AnimacionAscensor;
	
		
		void Start () {
		//Asiganmos a la variable AnimacionBoton el componente de Animacion de el boton.
		AnimacionBoton = Boton.GetComponent<Animation> ();
		//Asiganmos a la variable AnimacionAscensor el componente de Animacion de el ascensor.
		AnimacionAscensor = Ascensor.GetComponent<Animation> ();

		}
		//funcion que ejecutara la animacion de subir el ascensor.
		void funcion(){
			AnimacionAscensor.Play ("subirAscensor");
		}
		//Al entrar en tiger, si la animacion se esta ejecutandose, que no la reinicie, 
		//sino ejecuta las animaciones de pulsarBoton, expulsarBoton y bajar el ascensor.
		void OnTriggerEnter(Collider co){
		if (AnimacionBoton.isPlaying) {
						
		} else if(co.name == "Pj") {
				AnimacionBoton.Play ("pulsarBoton");
				
				AnimacionBoton.Play ("expulsarBoton");
				AnimacionAscensor.Play ("bajarAscensor");
			}	
		}
}
	
		
	