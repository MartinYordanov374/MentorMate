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
    constructor(width, height, id, x, y,widgetType)
    {
        this.id=id,
        this.width=width,
        this.height = height,
        this.x=x,
        this.y=y,
        this.widgetType=widgetType
    }
}

addNewGameButton.addEventListener('click',(event)=>{
    // create initial widget object with absolute X and Y coords if there are no elements in the list, prior to this one
    let xy_data = localStorage.getItem('XY_DATA')
    let parsed_xy_data=JSON.parse(xy_data)

    let xy_data_updated = localStorage.getItem('XY_DATA_UPDATED')
    let parsed_xy_data_updated =JSON.parse(xy_data_updated)

    if(objectCounter<=0)
    {
        newWidgetObj = new GamePanel(300,100,parsed_xy_data.id,parsed_xy_data.x,parsed_xy_data.y,widgetType)
        gamePanelWidgets.push(newWidgetObj)

    }
    // - get the previous object in the list and when creating the new object add the width and height to the last object's X and Y if they are, of course, legal variables
    else
    {
            newWidgetObj = new GamePanel(300,100,parsed_xy_data.id,parsed_xy_data.x,parsed_xy_data.y,widgetType)
            // save the objects in a list  
            // check if object is already in the list, if not add it
            if(gamePanelWidgets.indexOf(newWidgetObj)==-1)
            {
                gamePanelWidgets.push(newWidgetObj)

            }

    }
    objectCounter+=1
    gamePanelWidgets[parsed_xy_data_updated.id].x=parsed_xy_data_updated.x
    gamePanelWidgets[parsed_xy_data_updated.id].y=parsed_xy_data_updated.y

})
