from idlelib import window
from mailcap import show
from tokenize import String

import cv2
import imageio
import numpy as np
import matplotlib.pyplot as plt

from PIL import Image
from tkinter.filedialog import asksaveasfile

class image:

    def __init__(self,nameWindow,path):
        self.img = imageio.imread(path)
        self.orginal=self.img
        width = int(self.img.shape[1]/1.5)
        height = int(self.img.shape[0]/1.5)
        dim = (width, height)
        resize = cv2.resize(self.img, dim)
        self.img = resize
        self.x2=0
        self.y2=0
        self.points = []
        cv2.namedWindow=nameWindow
        cv2.imshow(nameWindow, self.img)
        self.nameWindow=nameWindow
        # cv2.setMouseCallback(nameWindow, self.blackAndWhite, self)
        # cv2.setMouseCallback("window", self.cut(), self)
        # cv2.setMouseCallback("window",self.addText());

    def add_text(self, text):
        def put_text(event, x, y, flags, param):
            if event == cv2.EVENT_LBUTTONDOWN:
                cv2.putText(self.img, text, (x, y), cv2.QT_FONT_BLACK,2.5,(0,180,255),3)
                cv2.imshow(self.nameWindow,self.img)
        cv2.setMouseCallback(self.nameWindow, put_text)

    def rectangle(self):
       def draw_rectangle(event, x, y, flags, param):
           if event == cv2.EVENT_LBUTTONDOWN:
               self.x2=x
               self.y2=y
           elif event == cv2.EVENT_LBUTTONUP:
               self.img=cv2.rectangle(self.img, (self.x2, self.y2), (x, y), (100,180,200), 5)
               cv2.imshow(self.nameWindow, self.img)
       cv2.setMouseCallback(self.nameWindow,draw_rectangle)

    def circle(self):
       def draw_circle(event, x, y, flags, param):
           if event == cv2.EVENT_LBUTTONDOWN:
               cv2.circle(self.img, (x, y), 20, (100,180,200), -1)
               cv2.imshow(self.nameWindow, self.img)
       cv2.setMouseCallback(self.nameWindow,draw_circle)

    def triangle(self):
       def draw_triangle(event, x, y, flags, param):
           if event == cv2.EVENT_LBUTTONDOWN:
               self.points.append((x, y))
               if len(self.points) == 3:
                   cv2.drawContours(self.img, [np.array(self.points)], 0, (100,180,200), 5)
                   cv2.imshow(self.nameWindow, self.img)
                   self.points.clear()
       cv2.setMouseCallback(self.nameWindow,draw_triangle)

    def blackAndWhite(self):
        self.img = cv2.cvtColor(self.img, cv2.COLOR_BGR2GRAY)
        cv2.imshow(self.nameWindow,self.img)
    def makeBorder(self):
        top, bottom, left, right = 10, 10, 10, 10  # border size in pixels
        border_color = [185, 250, 200]  # border color in BGR format (blue in this case)
        self.img = cv2.copyMakeBorder(self.img, top, bottom, left, right, cv2.BORDER_CONSTANT, value=border_color)
        cv2.imshow(self.nameWindow, self.img)
    def f1(self):
        kernel = np.ones((2, 7), np.uint8)
        self.img = cv2.erode(self.img, kernel, cv2.BORDER_REFLECT)
        cv2.imshow(self.nameWindow, self.img)
    def f2(self):
        image_rgb = cv2.cvtColor(self.img, cv2.COLOR_BGR2RGB)
        center = (image_rgb.shape[1] // 2, image_rgb.shape[0] // 2)
        angle = 30
        scale = 1
        rotation_matrix = cv2.getRotationMatrix2D(center, angle, scale)
        self.img = cv2.warpAffine(image_rgb, rotation_matrix, (self.img.shape[1], self.img.shape[0]))

    def apply_sepia_effect(self):
        intensity = 0.001
        sepia_filter = np.array([[0.272 + 0.728 * intensity, 0.534 + 0.466 * intensity, 0.131 + 0.869 * intensity],
                                 [0.349 + 0.651 * intensity, 0.686 + 0.314 * intensity, 0.168 + 0.832 * intensity],
                                 [0.393 + 0.607 * intensity, 0.769 + 0.231 * intensity, 0.189 + 0.811 * intensity]])

        self.img = cv2.transform(self.img, sepia_filter)

        cv2.imshow(self.nameWindow, self.img)
    def orginal_image(self):
        self.img = self.orginal
        cv2.imshow(self.nameWindow,self.img)
    def cut_img(self):
        ix = 0
        iy = 0
        def cut(event, x, y, flags, param):
            global ix, iy
            if event == cv2.EVENT_LBUTTONDOWN:
                ix = x
                iy = y
            elif event == cv2.EVENT_LBUTTONUP:
                self.img =self.img[iy:y ,ix:x]
                cv2.imshow(self.nameWindow,self.img)
        cv2.setMouseCallback(self.nameWindow, cut)


    def save_img(self, path):

        pil_img = Image.fromarray(self.img)

        pil_img.save(path)