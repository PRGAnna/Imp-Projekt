namespace VRTK.Examples
{
    using UnityEngine;

    public class Controller_Menu : MonoBehaviour
    {
        public GameObject menuObject;
        public GameObject menuObject2;
        public GameObject menuObject3;
        public GameObject menuObject4;

        private GameObject clonedMenuObject;
        private GameObject clonedMenuObject2;
        private GameObject clonedMenuObject3;
        private GameObject clonedMenuObject4;




        private bool menuInit = false;
        private bool menuActive = false;

        private void Start()
        {
            GetComponent<VRTK_ControllerEvents>().AliasMenuOn += new ControllerInteractionEventHandler(DoMenuOn);
            GetComponent<VRTK_ControllerEvents>().AliasMenuOff += new ControllerInteractionEventHandler(DoMenuOff);
            menuInit = false;
            menuActive = false;
        }

        private void InitMenu()
        {
            clonedMenuObject = Instantiate(menuObject, transform.position, Quaternion.identity) as GameObject;
            clonedMenuObject.SetActive(true);

            clonedMenuObject2 = Instantiate(menuObject2, transform.position, Quaternion.identity) as GameObject;
            clonedMenuObject2.SetActive(true);

            clonedMenuObject3 = Instantiate(menuObject3, transform.position, Quaternion.identity) as GameObject;
            clonedMenuObject3.SetActive(true);

            clonedMenuObject4 = Instantiate(menuObject4, transform.position, Quaternion.identity) as GameObject;
            clonedMenuObject4.SetActive(true);
            menuInit = true;
        }

        private void DoMenuOn(object sender, ControllerInteractionEventArgs e)
        {
            if (!menuInit)
            {
                InitMenu();
            }
            clonedMenuObject.SetActive(true);
            clonedMenuObject2.SetActive(true);
            clonedMenuObject3.SetActive(true);
            clonedMenuObject4.SetActive(true);
            menuActive = true;
        }

        private void DoMenuOff(object sender, ControllerInteractionEventArgs e)
        {
            clonedMenuObject.SetActive(false);
            clonedMenuObject2.SetActive(false);
            clonedMenuObject3.SetActive(false);
            clonedMenuObject4.SetActive(false);
            menuActive = false;
        }

        private void Update()
        {
            if (menuActive)
            {
                clonedMenuObject.transform.rotation = transform.rotation;
                clonedMenuObject.transform.position = transform.position;

                clonedMenuObject2.transform.rotation = transform.rotation;
                clonedMenuObject2.transform.position = transform.position;

                clonedMenuObject3.transform.rotation = transform.rotation;
                clonedMenuObject3.transform.position = transform.position;

                clonedMenuObject4.transform.rotation = transform.rotation;
                clonedMenuObject4.transform.position = transform.position;
            }
        }
    }
}