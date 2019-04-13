var elementId = "piemenu";
var elem = document.getElementById(elementId);
var slicesNum = elem.childElementCount;
var navAngles = [225,240,247.5,252,255,257.14285714285717,258.75];
//elem.setAttribute("data-wheelnav-titleheight",60-((slicesNum-2)*5));
//elem.setAttribute("data-wheelnav-titleheight",slicesNum ==2? 180/slicesNum : 60);

var piemenu = new wheelnav(elementId);
piemenu.spreaderInTitle = icon.plus;
piemenu.spreaderOutTitle = icon.cross;
piemenu.spreaderRadius = piemenu.wheelRadius * 0.34;
piemenu.clockwise = true;
piemenu.sliceInitPathFunction = piemenu.slicePathFunction;
piemenu.initPercent = 0.1;
piemenu.wheelRadius = piemenu.wheelRadius * 0.83;
piemenu.navItemsContinuous = true;
piemenu.sliceAngle = 360/slicesNum;
piemenu.createWheel();
var toolTips = ['Your Profile','Search A Movie','My Playlists','Dashboard'];
piemenu.setTooltips(toolTips.slice(0,slicesNum));