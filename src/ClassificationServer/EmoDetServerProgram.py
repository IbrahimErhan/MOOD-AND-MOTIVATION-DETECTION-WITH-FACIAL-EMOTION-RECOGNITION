from EmotionDetection_API import CNN_Model
import numpy as np
from numpy import asarray
import requests
import json

class jsonObject:
    objID = 0
    cameraID = 0
    clusterID = 0
    features = 0
    date = ""
    def __init__(self, objID,cameraID, clusterID, features,date):
        self.objID = objID
        self.cameraID = cameraID
        self.clusterID = clusterID
        self.features = features
        self.date = date

def getAllFaceFeaturesFromMongoDB(url):
    x = requests.get(url)
    jsonData = x.json()
    allFeatures = []
    for j in jsonData:
        objID = j["objID"]
        splitedData = j["features"].split(' ')
        clusterID = j["clusterID"]
        cameraID = j["cameraID"]
        date = j["date"]
        splitedData.remove(splitedData[-1])
        getData = np.reshape(asarray(splitedData,dtype=np.uint8),(-1,48))
        jsonobj = jsonObject(objID,cameraID, clusterID, getData,date)
        allFeatures.append(jsonobj)
        
    return allFeatures
    
def getFaceFeaturesFromMongoDB(dataCounter):
    url = "http://localhost:5000/GetCOLS01"
    x = requests.get(url + '/' + str(dataCounter))
    jsonData = x.json()
    allFeatures = []
    for j in jsonData:
        
        objID = j["_id"]
        splitedData = j["features"].split(' ')
        clusterID = j["clusterID"]
        cameraID = j["cameraID"]
        date = j["date"]
        splitedData.remove(splitedData[-1])
        getData = np.reshape(asarray(splitedData,dtype=np.uint8),(-1,48))
        jsonobj = jsonObject(objID,cameraID, clusterID, getData,date)
        allFeatures.append(jsonobj)
        
    return allFeatures

def getFirstFaceFeaturesFromMongoDB():
    url = "http://localhost:5000/FindOneCOLS01"
    x = requests.get(url)
    jsonData = x.json()
    objID = jsonData["_id"]
    splitedData = jsonData["features"].split(' ')
    clusterID = jsonData["clusterID"]
    cameraID = jsonData["cameraID"]
    date = jsonData["date"]
    splitedData.remove(splitedData[-1])
    getData = np.reshape(asarray(splitedData,dtype=np.uint8),(-1,48))
    jsonobj = jsonObject(objID,cameraID, clusterID, getData,date)
        
    return jsonobj

def sendFaceFeaturesToPostgre(feture,emotionIndex):
    postgreURL = "http://localhost:3000/EmotionData"
    sendData = {
            "CameraID" : str(feature.cameraID),
            "EmotionID" : str(emotionIndex),
            "CaptureDate" : str(feature.date)
            }
    x = requests.post(postgreURL, sendData)
    print(x.text)

def deleteFaceFeatureFromMongoDB(objID):
    postgreURL = "http://localhost:5000/DelCOLS01/" + str(objID)
    x = requests.get(postgreURL)
    print(x.text)
    
"""
while(True):
    try:
        getFeatures = getFaceFeaturesFromMongoDB(dataCounter)
        for feature in getFeatures:
            emotionIndex, emotionString = model.Predict(feature.features)
            sendFaceFeaturesToPostgre(feature, emotionIndex)
            deleteFaceFeatureFromMongoDB(feature.objID)
        dataCounter += 1
    except:
        print("Waiting for new data...")
        continue
"""

model = CNN_Model()
dataCounter = 0
while(True):
    try:
        feature = getFirstFaceFeaturesFromMongoDB()
        emotionIndex, emotionString = model.Predict(feature.features)
        sendFaceFeaturesToPostgre(feature, emotionIndex)
        deleteFaceFeatureFromMongoDB(feature.objID)
    except:
        print("Waiting for new data...")
        continue
