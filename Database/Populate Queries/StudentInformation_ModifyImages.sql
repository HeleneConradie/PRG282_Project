UPDATE StudentInformation SET[StudentImage] = (SELECT StudentImage FROM OPENROWSET(BULK N'C:\Users\helen\Pictures\MorneJVR.jpg', SINGLE_BLOB) ImageSource(StudentImage)) WHERE StudentNumber = 'KP124';

UPDATE StudentInformation SET[StudentImage] = (SELECT StudentImage FROM OPENROWSET(BULK N'C:\Users\helen\Pictures\HeleneC.jpg', SINGLE_BLOB) ImageSource(StudentImage)) WHERE StudentNumber = 'KP123';