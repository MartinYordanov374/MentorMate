let gamePanelCounter = -1
let statisticsCounter = -1
$(document).ready()
{
    $('#newGame').on('click',()=>
    {
        createGamePanel()
        collisionGamePanels()
    })
    $('#scoreboard').on('click', ()=>
    {
        $(`.scoreboardPanel`).draggable({
            containment: '.adminPanelContainer',
            create: function()
            {
                let rect1 = $(this).offset()
                let firstRectangleId = $(this).attr('id')
                $('.scoreboardContainer').children('div').each(function () {
                    let secondRectangleId = $(this).attr('id')
                    if(firstRectangleId!=secondRectangleId)
                    {
                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap

                        if(overlapArea>0)
                        {
                            $('#'+secondRectangleId).insertAfter('#'+firstRectangleId)

                        }
                    }
                })
            },
            drag: function()
            {
                let rect1 = $(this).offset()// scoreboard 
                let rect1_width = $(this).width()
                let rect1_height = $(this).height()

                let firstRectangleId = $(this).attr('id')
                $('.scoreboardContainer').children('div').each(function () {
                    let secondRectangleId = $(this).attr('id')
                    if(firstRectangleId!=secondRectangleId)
                    {
                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap

                        if(overlapArea>0)
                        {
                            $('#'+firstRectangleId).draggable({
                            revert: true
                            })
                        }
                        else
                        {
                            $('#'+firstRectangleId).draggable({
                            revert: false
                            })
                        }                   
                    }
                })
                $('.statisticsPanelContainer').children('div').each(function(){
                    let rect2 = $(this).offset() // statistics
                    let rect2_width = $(this).width()
                    let rect2_height = $(this).height()
                    let x_overlap = Math.max(0, Math.min(rect1.left+rect1_width, rect2.left+rect2_width) - Math.max(rect1.left, rect2.left));
                    let y_overlap = Math.max(0, Math.min(rect2.top+rect2_height, rect1.top+rect1_height) - Math.max(rect1.top, rect2.top));
                    let overlapArea = x_overlap*y_overlap
                    if(overlapArea>0)
                    {
                        $('#'+firstRectangleId).addClass('gamePanelOnCollision')
                        $('#'+firstRectangleId).draggable({
                            revert: true
                        })
                    }
                    else
                    {
                        $('#'+firstRectangleId).removeClass('gamePanelOnCollision')

                        $('#'+firstRectangleId).draggable({
                            revert: false
                        })
                    }
                })

            }
        })
    })
    //200x200 statistics widget, draggable, collidable with other statistics widgets
    $('#statistics').on('click', ()=>
    {
        createStatisticsPanel()
        collisionStatisticsPanels()
    })

    function createGamePanel()
    {
        gamePanelCounter+=1
        const newElement = document.createElement('div'); // this line here creates the div element
        newElement.draggable=true // this line here makes the div element draggable
        newElement.className='individualGamePanel'+` ${gamePanelCounter}`; // this line gives the div element a className
        newElement.id='individualGamePanel'; // this line gives the div element an ID
        newElement.style.position = 'relative' // this line gives the div element the position attributes of relative
        const newElementGrid = document.querySelector('.gamesPanel'); // this line here selectes the games panel that I'll use to append the newly created element to
        newElementGrid.appendChild(newElement); // this line appends the div to the gamesPanel
    }
    
    function createStatisticsPanel()
    {
        statisticsCounter+=1
        const newElement = document.createElement('div'); // this line here creates the div element
        newElement.draggable=true // this line here makes the div element draggable
        newElement.className='individualStatisticsPanel'; // this line gives the div element a className
        newElement.id=`statistics_${statisticsCounter}`; // this line gives the div element an ID
        newElement.style.position = 'relative' // this line gives the div element the position attributes of relative
        const newElementGrid = document.querySelector('.statisticsPanelContainer'); // this line here selectes the statistics panel that I'll use to append the newly created element to
        newElementGrid.appendChild(newElement); // this line appends the div to the gamesPanel
    }

    function collisionGamePanels()
    {
        $('.individualGamePanel').draggable({ // here I use JQUERY to implement the dragging of the elements
            containment: '.adminPanelContainer', // this line permits the movement of the dragged elements outside of the admin panel
            create: function()
            {
                let classCurrentWidget = $(this).attr('class')
                let widgetNumber = classCurrentWidget.split(' ')[1]         
                let rect1 = $(this).offset()
                $('.gamesPanel').children('div').each(function () {
                    if(widgetNumber!=$(this).attr('class').split(' ')[1])
                    {
                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap

                        if(overlapArea>0)
                        {
                            $(this).insertAfter($('.'+classCurrentWidget.split(' ')[1]))
                        }
                    }
                })

            },
            drag: function()
            {
                let classCurrentWidget = $(this).attr('class')
                let widgetNumber = classCurrentWidget.split(' ')[1]                            
                let rect1 = $(this).offset()
                $('.gamesPanel').children('div').each(function () {
                    if(widgetNumber != $(this).attr('class').split(' ')[1])
                    {   
                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap

                        if(overlapArea>0)
                        {
                            $('.'+classCurrentWidget.split(' ')[1]).addClass('gamePanelOnCollision')
                            $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                revert: true
                            })
                        }
                        if(overlapArea<=0)
                        {
                            $('.'+classCurrentWidget.split(' ')[1]).removeClass('gamePanelOnCollision')

                            $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                revert: false
                            })
                        }

                    }
                });
                $('.statisticsPanelContainer').children('div').each(function () {

                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap

                        if(overlapArea>0)
                        {
                            if(overlapArea>0)
                            {
                                $('.'+classCurrentWidget.split(' ')[1]).addClass('gamePanelOnCollision')
                                $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                    revert: true
                                })
                            }
                        }
                        if(overlapArea<=0)
                        {
                            $('.'+classCurrentWidget.split(' ')[1]).removeClass('gamePanelOnCollision')

                            $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                revert: false
                            })
                        }

                    
                
                });
                $('.scoreboardContainer').children('div').each(function(){

                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap
                        if(overlapArea>0)
                        {
                
                                $('.'+classCurrentWidget.split(' ')[1]).addClass('gamePanelOnCollision')
                                $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                    revert: true
                                })
                                console.log('collision')
                            
                        }
                        if(overlapArea<=0)
                        {
                            $('.'+classCurrentWidget.split(' ')[1]).removeClass('gamePanelOnCollision')

                            $('.'+classCurrentWidget.split(' ')[1]).draggable({
                                revert: false
                            })
                            console.log('no collision')

                        }

                    
                }) 
            }
        })
        
    }    
    
    function collisionStatisticsPanels()
    {
        $('.individualStatisticsPanel').draggable({
            containment: '.adminPanelContainer',
            drag: function()
            {
                let rect1 = $(this).offset()
                let firstRectangleId = $(this).attr('id')
                let statisticsRectangle_ID = $(this).attr('id')
                // collision with other statistics panels
                $('.statisticsPanelContainer').children('div').each(function () {
                    let secondRectangleId = $(this).attr('id')
                    if(firstRectangleId!=secondRectangleId)
                    {   
                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap
                        if(overlapArea>0)
                        {
                            $('#'+firstRectangleId).draggable({
                            revert: true
                            })
                        }
                        else
                        {
                            $('#'+firstRectangleId).draggable({
                            revert: false
                            })
                        }                   
                    }
                })
                // collision with scoreboard panels
                $('.scoreboardContainer').children('div').each(function(){

                        let rect2 = $(this).offset()
                        let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                        let y_overlap = Math.max(0, Math.min(rect1.top+$(this).height(), rect2.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                        let overlapArea = x_overlap*y_overlap
                        if(overlapArea>0)
                        {
                            $('#'+statisticsRectangle_ID).addClass('gamePanelOnCollision')
                            $('#'+statisticsRectangle_ID).draggable({
                                revert: true
                            })
                        }
                        else
                        {
                            $('#'+statisticsRectangle_ID).removeClass('gamePanelOnCollision')
                            $('#'+statisticsRectangle_ID).draggable({
                                revert: false
                            })

                        }
                }) 
                $('.gamesPanel').children('div').each(function (){
                    let rect2=$(this).offset()
                    let x_overlap = Math.max(0, Math.min(rect1.left+$(this).width(), rect2.left+$(this).width()) - Math.max(rect1.left, rect2.left));
                    let y_overlap = Math.max(0, Math.min(rect2.top+$(this).height(), rect1.top+$(this).height()) - Math.max(rect1.top, rect2.top));
                    let overlapArea = x_overlap*y_overlap
                    if(overlapArea>0)
                    {
                        $('#'+statisticsRectangle_ID).addClass('gamePanelOnCollision')
                        $('#'+statisticsRectangle_ID).draggable({
                            revert: true
                        })
                    }
                    else
                    {
                        $('#'+statisticsRectangle_ID).removeClass('gamePanelOnCollision')
                        $('#'+statisticsRectangle_ID).draggable({
                            revert: false
                        })
                    }
                    
                })
            }
            
        })
    }


}