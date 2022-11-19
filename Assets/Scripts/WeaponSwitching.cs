using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    /*Activar y desactivar las armas del WeaponHolder*/

   /*Esta variable va a determinar que arma se escoge*/
    public int selectedWeapon = 0;
    
    
    void Start()
    {
        SelectWeapon();   /*Llamo al metodo de selectWeapon*/
    }

  
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;   /*declaro una variable */

         /*Se puede cambiar de arma usando el scroll del mouse*/
         /*Si es mayor a cero se selecciona la siguiente arma en la fila*/
        if(Input.GetAxis("Mouse ScrollWheel") > 0f )
         {
            if(selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }


         if(Input.GetAxis("Mouse ScrollWheel") < 0f )
         {
            if(selectedWeapon <=0)
                selectedWeapon = transform.childCount -1;
            else
                selectedWeapon--;
        }

        /*Cambiamos las armas usando el teclado, usando 1,2,3 */
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }

         if(Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >=2)
        {
            selectedWeapon = 1;
        } 

         if(Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >=3)
        {
            selectedWeapon = 2;
        }

          if(Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >=4)
        {
            selectedWeapon = 3;
        } 

     /*Si la anterior arma es diferente a la seleccionada se llama al metodo de seleccion de arma*/
        if(previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }


       
    }

    /*Si el index osea i coincide con la weapon esta se activa y si no , no se activa*/
    /*De esta forma se hace que solo se active una arma a la vez*/
    void SelectWeapon()
    {
        int i=0;
        foreach (Transform weapon in  transform)   /*loop en todas las weapons*/
         {
            if (i == selectedWeapon)
            weapon.gameObject.SetActive(true);  /*se activa la weapon*/
         else 
            weapon.gameObject.SetActive(false); /*enable de weapon*/
            i++;
            
        }
    }
}
