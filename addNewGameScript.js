const addNewGameButton = document.getElementById('newGame')
let adminPanelContainer = document.getElementById('adminPanelContainer')
let maxWidth = adminPanelContainer.clientWidth
let maxHeight = adminPanelContainer.clientHeight

let newWidgetObj;
let gamePanelWidgets=[]
let finalWidgetsToBeShown=[]
let objectCounter = 0
let isValidX = false
let isValidY = false
let x = 0
let y = 0
class GamePanel
{
    constructor(width, height, x, y)
    {
        this.width=width,
        this.height = height,
        this.x=x,
        this.y=y
    }
}

addNewGameButton.addEventListener('click',(event)=>{
    // create initial widget object with absolute X and Y coords if there are no elements in the list, prior to this one
    if(objectCounter<=0)
    {
        newWidgetObj = new GamePanel(300,100,x,y)
        gamePanelWidgets.push(newWidgetObj)

    }
    // - get the previous object in the list and when creating the new object add the width and height to the last object's X and Y if they are, of course, legal variables
    else
    {
        x+=300
        y+=300
        if(x>maxWidth)
        {
            x=maxWidth
            
        }
        else
        {
            isValidX=true
        }
        if(y>maxHeight)
        {
            y=maxHeight
        }
        else
        {
            isValidY=true
        }
        if(isValidX && isValidY)
        {
            newWidgetObj = new GamePanel(300,100,x,y)
            // save the objects in a list  
            gamePanelWidgets.push(newWidgetObj)
        }

    }
    objectCounter+=1
    // create a new HTML element by the objects in the list
    createElements()

})

function createElements()
{
    let gamePanelContainer = document.getElementById('gamesPanelContainer')
    for(element of gamePanelWidgets)
    {
        console.log(element)
        const newElement = document.createElement('div');
        newElement.draggable=true
        newElement.classList.add('individualGamePanel');
        const newElementGrid = document.querySelector('.gamesPanel');
        newElementGrid.appendChild(newElement);

    }
    gamePanelWidgets=[]
}