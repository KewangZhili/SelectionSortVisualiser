**INSTRUCTIONS TO RUN**:
 ------------------------------------------------------------------------------
	OPEN 210101050_Assignment1B file after extracting
	Add the file to the location where you have loaded visual basic on your home device
	Then inside the 210101050_Assignement1C file,search for 210101050_Assignment1B_vb  Visual Basic Project file
	Go to the  Form1.vb file as visible in the "Solution Explorer" or Form1.vb[Design] file
	Then run either the code or the form(F5) 
	Then follow instructions as they appear on screen
------------------------------------------------------------------------------

------------------------------------------------------------------------------
  **GUIDELINES**
  ------------------------------------------------------------------------------
  
   
   1.Enter the size of the array and the elements of the array following
     the above instruction.Then press "ENTER" button.
   2.When this happens all other buttons except "Start Sort" button are
     disabled.
   3.Then press Start Sort button to view the output.During this all 
     buttons barring "Start Stop" button itself remains disabled
  4.When finally output occurrs only "CLEAR ALL" button is enabled
  5.Upon pressing Cllear All once,all outputs are cleared,and the other
      2 clear buttons are enabled.Pressing CLEAR ALL AGAIN does the 
      same thing as pressing clearsize and clear array buttons.
  6.And then all input textboxes are again turned off from Read Only 
     mode,which gets turned on when ENTER is pressed earlier.
   7.Follow the same cycle again 


------------------------------------------------------------------------------
 Enter size of the array in the left box and then enter the elements of the
 array in the bigger right box.Only then press "ENTER".
-------------------------------------------------------------------------------
**NOTE**:
------------------------------------------------------------------------------
           1.Size has to be <=20 and >=0
           2.Array elements have to be <=100 and >=-100
           3.Spacing has to be in the correct formant viz.
                 i.Size of the array has to be <=20 and >=1
                i i.Enter only numbers (<=100 and >=-100) in the array
               iii.Before entering "ENTER" button,all buttons are locked
               iv.To enter again after sorting all inputs clear all inputs and 
                    continue  the process again.

------------------------------------------------------------------------------


FUNCTIONS AND ELEMENTS USED


    'clear btn1->clears the size of array 
    'clear btn2->clear the array elements
    'enter btn:
    '   checks for correctness of input in size_ and array_ input text boxes and turns off unneccessary buttons 
    'sort btn:
    '   starts a timer
    'timer tick:
    '   with each tick of clock one iteration of selection sort gets executed and rich text boxes containing one iteration of input 
    '   gets generated
    'PerformSelectionSort:
    '   code for one iteration of selection sort
    '   it takes in minIndex ByRef so that it could be coloured Red
    'Display Array:
    '   after each iteration of selection sort in each time_tick,this function actually generates the rich textboxes
    '   and does the actual colouring
    'Form1:
    '   Overall Form

------------------------------------------------------------------------------------------------------------------------------------

	VARIABLES USED:


	 'num:size of the array taken as input
    'i,j ->variables to be used in for loops in the programme
    Dim currentIndex As Integer = 0
    'currennIndex:store the current iteration that is being compared to (i of the outer loop)

------------------------------------------------------------------------------------------------------------------------------------

CODE LOGIC::

	"Follow the comments made in the Form1.vb source code"

------------------------------------------------------------------------------------------------------------------------------------

  
