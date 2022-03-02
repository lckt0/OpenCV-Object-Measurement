import cv2
import helper
import json

img_f = open('./settings.json')
settings = json.load(img_f)

webcam = settings['useWebcam']
path = settings['imgFilePath']
cap = cv2.VideoCapture(int(settings['webcamIndex']))
dashed_gap = int(settings['dashGapScale'])
cap.set(10, 160)
resArray = settings['resolution'].split('x')
#print(int(resArray[0]), int(resArray[1]))
cap.set(3, int(resArray[0]))
cap.set(4, int(resArray[1]))
scale = int(settings['generalScale'])
wP = 210 * scale
hP = 297 * scale
windowName = settings['windowName']

print('Settings loaded.')

checkPrintLoop = False

while True:
    if checkPrintLoop == False:
        print('Image process loop started.')
        checkPrintLoop = True
    if webcam:
        success, img = cap.read()
        imgLast = img
    else:
        img = cv2.imread(path)

    imgContours, conts = helper.getBorders(img, minArea=50000, filter=4)
    if len(conts) != 0:
        biggest = conts[0][2]
        # print(biggest)
        imgWarp = helper.warpImg(img, biggest, wP, hP)
        imgContours2, conts2 = helper.getBorders(imgWarp, minArea=2000, filter=4, cThr=[50, 50], draw=False)
        if len(conts) != 0:
            for obj in conts2:
                #print(obj[2])
                
                #cv2.polylines(imgContours2, helper.getDashedPoint(obj[2]), True, (0, 140, 255), 2)
                #helper.drawpoly(imgContours2, [obj[2]], (0, 140, 255), 2)

                nPoints = helper.reorder(obj[2])
                nW = round((helper.findDis(nPoints[0][0]//scale, nPoints[1][0]//scale)/10), 1)
                nH = round((helper.findDis(nPoints[0][0]//scale, nPoints[2][0]//scale)/10), 1)

                objDef1 = (nPoints[0][0][0], nPoints[0][0][1]), (nPoints[1][0][0], nPoints[1][0][1])
                objDef2 = (nPoints[0][0][0], nPoints[0][0][1]), (nPoints[2][0][0], nPoints[2][0][1])

                #print(obj[2][0][0], obj[2][1][0])

                helper.dashLine(imgContours2, obj[2][0][0], obj[2][1][0], (0, 140, 255), 2, 'dotted', dashed_gap)
                helper.dashLine(imgContours2, obj[2][1][0], obj[2][2][0], (0, 140, 255), 2, 'dotted', dashed_gap)
                helper.dashLine(imgContours2, obj[2][2][0], obj[2][3][0], (0, 140, 255), 2, 'dotted', dashed_gap)
                helper.dashLine(imgContours2, obj[2][3][0], obj[2][0][0], (0, 140, 255), 2, 'dotted', dashed_gap)
                
                #helper.dashLine(imgContours2, objDef2[0], objDef2[1], (0, 140, 255), 2)

                #cv2.arrowedLine(imgContours2, objDef1[0], objDef1[1], (255, 0, 255), 3, 8, 0, 0.05)
                #cv2.arrowedLine(imgContours2, objDef2[0], objDef2[1], (255, 0, 255), 3, 8, 0, 0.05)
                
                x, y, w, h = obj[3]
                #print(x, y, w, h)
                cv2.putText(imgContours2, '{}cm'.format(nW), (x + 30, y - 10), cv2.QT_FONT_NORMAL, 0.5, (0, 0, 0), 1)
                cv2.putText(imgContours2, '{}cm'.format(nH), (x - 70, y + h // 2), cv2.QT_FONT_NORMAL, 0.5,(0, 0, 0), 1)
        imgLast = imgContours2
        #cv2.imshow('A4', imgContours2)

    img = cv2.resize(img, (0, 0), None, 0.5, 0.5)
    cv2.imshow(windowName, imgLast)
    cv2.waitKey(1)
    if cv2.getWindowProperty(windowName, cv2.WND_PROP_VISIBLE) <= 0:
        cv2.destroyAllWindows()
        break
