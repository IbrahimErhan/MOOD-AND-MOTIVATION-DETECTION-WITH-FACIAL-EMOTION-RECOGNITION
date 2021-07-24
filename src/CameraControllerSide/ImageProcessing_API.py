import cv2
from PIL import Image
import numpy as np
from numpy import asarray

class Image_Processor:

    def ConvertGrayScale(self,image): # image : 8bit cv2 image

        image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

        return image
    
    def CropFaces(self, frame, detectedFaces, cropSize = 48): # frame : Image
        
        faces = []
        for i,faceFrame in enumerate(detectedFaces):
            image = Image.fromarray(frame)
            size_array = []
            size_array.append(faceFrame.top())
            size_array.append(image.height - faceFrame.bottom())
            size_array.append(faceFrame.left())
            size_array.append(image.width - faceFrame.right())
            size_array.sort()
            cropArea = (faceFrame.left() - size_array[0] , faceFrame.top() - size_array[0], faceFrame.right() + size_array[0], faceFrame.bottom() + size_array[0])
            croppedImage = image.crop(cropArea)
            faces.append(croppedImage)
        return faces