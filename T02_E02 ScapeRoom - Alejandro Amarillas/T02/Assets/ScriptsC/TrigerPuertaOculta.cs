using UnityEngine;
using System.Collections;

public class TrigerPuertaOculta : MonoBehaviour {
	//Declaramos el game object para la puerta, una variable del tipo animacion 
	//y otra booleana para saber cuando esta abierta la puerta.
		[SerializeField]
		private GameObject PuertaOculta;
		private Animation AnimacionPuertaOculta;
		private bool Pabierta =false;
		
	void Start () {
			//A AnimacionPuerta le asiganmos el componente de animacion del gameObject PuertaOculta
			AnimacionPuertaOculta = PuertaOculta.GetComponent<Animation> ();
		}
		//funcion que ejecuta la animacion 2 de abrir puerta
		void fun_abrirPuertaOculta2(){
			AnimacionPuertaOculta.Play ("abrirPuertaOculta2");
		}
		//funcion que ejecuta la animacion 2 de cerrar puerta
		void fun_cerrarPuertaOculta2(){
			AnimacionPuertaOculta.Play ("cerrarPuertaOculta2");
		}
		//si entramos en el triger y la puerta esta cerrada ejecutamos al animacion 1 de abrir
		void OnTriggerEnter(Collider co){
			if (Pabierta == false) {
						AnimacionPuertaOculta.Play ("abrirPuertaOculta");
						Pabierta = true;
				}
		}
		//si salimos del triger y la puerta esta abierta, ejecutamos la animacion de cerrar.
		void OnTriggerExit(Collider co){
			if (Pabierta == true) {
						AnimacionPuertaOculta.Play ("cerrarPuertaOculta1");
						Pabierta = false;
				}
			
		}
		
	}
