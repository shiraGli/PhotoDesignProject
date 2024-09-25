
from tkinter import *
from tkinter import filedialog
import Photo
from tkinter import *
import tkinter as tk
from tkinter import *
from tkinter import ttk
from tkinter.filedialog import asksaveasfile
class Window:
 def __init__(self):
     self.top = Tk()
     self.top.title("photo")
     self.background_color = "#FEFEFE"  # אדום
     self.top.config(bg=self.background_color)
     self.title=Label(self.top, text='Design image!', font="Courier 25 bold", fg="#DB7DF3", bg="#FEFEFE")
     self.choose=Button(self.top,text = "choose image",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady=10,activebackground="#FEFEFE",command=self.choose_image)
     self.cut=Button(self.top, text = "Cut image",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady=10,activebackground="#FEFEFE",command=self.cut)
     self.add=Button(self.top, text = "Add Text",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady = 10,activebackground="#FEFEFE",command=self.putText)
     self.drawShape=Button(self.top, text = "Efect",bg="#ECBDF8",height=8,width=21,font=("Harlow Solid Italic",18),pady = 10,activebackground="#FEFEFE",command=self.chooseShape)
     self.aaaa=Button(self.top, text = "Draw Shape",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady = 10,activebackground="#FEFEFE",command=self.shape)
     self.save=Button(self.top, text = "Save",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady = 10,activebackground="#FEFEFE",command=self.save_image)
     self.exit=Button(self.top, text = "Exit",bg="#ECBDF8",height=8,width=22,font=("Harlow Solid Italic",18),pady = 10,activebackground="#FEFEFE",command=self.exit)
     self.position()
     self.m=None
     self.top.mainloop()
 def position(self):
    self.choose.grid(row=0,column=0)
    self.cut.grid(row=0, column=1, padx=10,pady=30)
    self.add.grid(row=0, column=2,padx=10)
    self.drawShape.grid(row=0, column=3, padx=10)
    self.aaaa.grid(row=3, column=0)
    self.save.grid(row=3, column=1,pady=10)
    self.exit.grid(row=3, column=2)
    self.title.grid(row=3, column=3, pady=20)
    global entry
 def choose_image(self):
   file_path = filedialog.askopenfilename(title="בחר תמונה", filetypes=[("תמונות", "*.jpg *.png *.gif")])
   self.m =Photo.image("window",file_path)
 def exit(self):
    self.top.quit()
 def shape(self):
     self.win = Tk()
     self.win.geometry("450x225")
     ttk.Button(self.win, text="rectangle", width=20, command=self.m.rectangle).pack(pady=7)
     ttk.Button(self.win, text="circle", width=20, command=self.m.circle).pack(pady=7)
     ttk.Button(self.win, text="triangle", width=20, command=self.m.triangle).pack(pady=7)
 def chooseShape(self):
     self.win = Tk()
     self.win.geometry("450x225")
     ttk.Button(self.win, text="makeBorder", width=20, command=self.m.makeBorder).pack(pady=7)
     ttk.Button(self.win, text="blackAndWhite", width=20, command=self.m.blackAndWhite).pack(pady=7)
     ttk.Button(self.win, text="effect1", width=20, command=self.m.f1).pack(pady=7)
     ttk.Button(self.win, text="effect2", width=20, command=self.m.f2).pack(pady=7)
     ttk.Button(self.win, text="effect3", width=20, command=self.m.apply_sepia_effect).pack(pady=7)
     ttk.Button(self.win, text="orginal", width=20, command=self.m.orginal_image).pack(pady=7)
 def display_text(self):
     string = self.entry.get()
     self.m.add_text(string)
     self.label.configure(text=string)
 def putText(self):
   self.win = Tk()
   self.win.geometry("450x250")
   self.label = Label(self.win, text="", font=("Courier 22 bold"))
   self.label.pack()
   self.label2=Label(self.win,text="enter your txet",font=("Courier 22 bold"))
   self.label2.pack()
   self.entry = Entry(self.win, width=40)
   self.entry.focus_set()
   self.entry.pack()
   ttk.Button(self.win, text="Okay", width=20, command=self.display_text).pack(pady=20)
 def cut(self):
     self.m.cut_img()



 def save_image(self):
    if self.m:
        save_path = filedialog.asksaveasfilename(defaultextension=".jpg",
                                                 filetypes=(("JPEG files", "*.jpg"), ("All files", "*.*")))
        if save_path:
            self.m.save_img(save_path)


w=Window()
