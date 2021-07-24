from ImageProcessing_API import Image_Processor
import cv2
import dlib
import numpy as np
from numpy import asarray
import requests
import json
import glob
import os
from datetime import date

def arrayToString(array):
    str11 = ""
    for i in range(0, len(array)):
        for j in range(0, len(array[i])):
            str11 += (str(array[i][j]) + (" "))
    return str11

def sendFaceFeaturesToMongoDB(dataToSend, cameraID, clusterID,dataCounter):
    url = 'http://localhost:5000/COLS01'
    data = asarray(dataToSend)
    data = cv2.resize(data, (48, 48))
    data = arrayToString(data)
    today = date.today()
    sendData = { 
                "features" : data,
                "cameraID" : str(cameraID),
                "clusterID" : str(clusterID),
                "date" : str(today),
                "dataCounter" : str(dataCounter)
                }

    x = requests.post(url, sendData)
    print(x.text)

dataCounter = 0
frameSource = 'FrameSource'
imageProcessor = Image_Processor()
face_detector = dlib.get_frontal_face_detector()

for f in glob.glob(os.path.join(frameSource, "*.png")):
    img = cv2.imread(f)
    img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    detectedFaces = face_detector(img, 1)
    faces = imageProcessor.CropFaces(img, detectedFaces)
    clusterID = 1
    cameraID = 1
    for face in faces:
        sendFaceFeaturesToMongoDB(face, cameraID=cameraID, clusterID = clusterID, dataCounter = dataCounter)
        dataCounter += 1
