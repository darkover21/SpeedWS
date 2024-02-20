
using System.Collections.Generic;
using UnityEngine;

public class CustomPanelController : PanelController
{
    public void GoToCreateNewPostItPanel() 
    {
        
        GoToPanel("NewPostIt");
    }

    public void ReturnToMainPanel(bool accepted)
    {
       
        GoToPanel("MainMenu");
    }


}
