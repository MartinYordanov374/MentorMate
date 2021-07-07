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
let widgetType = 'gamePanel'
class GamePanel
{
    constructor(width, height, x, y,widgetType)
    {
        this.width=width,
        this.height = height,
        this.x=x,
        this.y=y,
        this.widgetType=widgetType
    }
}

addNewGameButton.addEventListener('click',(event)=>{
    // create initial widget object with absolute X and Y coords if there are no elements in the list, prior to this one
    if(objectCounter<=0)
    {
        newWidgetObj = new GamePanel(300,100,x,y,widgetType)
        gamePanelWidgets.push(newWidgetObj)

    }
    // - get the previous object in the list and when creating the new object add the width and height to the last object's X and Y if they are, of course, legal variables
    else
    {
        // x+=300
        // y+=300
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
            newWidgetObj = new GamePanel(300,100,x,y,widgetType)
            // save the objects in a list  
            gamePanelWidgets.push(newWidgetObj)
            console.log('valid')
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
            const newElement = document.createElement('div');
            newElement.draggable=true

            newElement.className='individualGamePanel';
            newElement.id='individualGamePanel';
            newElement.style.position = 'relative'

            newElement.left = element.x
            newElement.top = element.y


            const newElementGrid = document.querySelector('.gamesPanel');
            newElementGrid.appendChild(newElement);
    
        }
    gamePanelWidgets=[]
}