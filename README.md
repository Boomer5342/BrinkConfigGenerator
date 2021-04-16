# Brink Config Generator

## Introduction

> This program was developed with the intention of simplifying the creation of Brink Config files. Brink is a Cloud based POS software that uses 2 types of configs (Register and Kitchen). Each config is made with XML and uses different parameters to tell the device what Register or Kitchen they are and what portal they run on.

## Code Samples

> Before XML generation the program will run the ErrorCheckingService class. 3 different options are available for generating XML configs. Reg & Video, Single Reg, Single Video.

```C#
// Error Cehck for Reg & Videos
if (!ErrorCheckingService.RegAndVidErrorChecker(comboIndex, enabled, RegAndVidTextBoxes(), VideosTextBoxes(), enabledVideos)) return;
// Takes in 5 parameters (Selected Index for combobox, If Video Combobox is enabled, Reg & Video Textbox Multideminsional Arrays, List of Enabled Videos

// Error Check for Single Reg
if (!ErrorCheckingService.SingleRegErrorChecker(RegTextBoxes(), isStatOne)) return;
// Take in 2 Parameters (Reg Text boxes array, And Bool of if this station will be a station 1)

// Error Check for Single Video
if (!ErrorCheckingService.SingleVideoErrorChecker(VidTextBoxes())) return;
//Takes in 1 Parameter (array of video Textboxes)
```

> After error checking begins the XML Generation process. XML generation uses 3 different functions from a separate XMLModificationService class. Each function takes in a set of parameters (4 Parameters for Station 1, & 5 Parameters for all videos and Stations 2+).

```C#
for (int i = 1; i <= stationCount; i++)
{
  if (i == 1)
    {
      stationFullPath = _topDir + "\\Station 1";
      XMLModificationService.RegisterOneXMLModifier(RegAndVidTextBoxes(), stationFullPath, "\\Register.cfg", 0); 
      // Parameters needed (Multi Dimensional String Array, Full Path for File save location, File Name Used, Index to loop through XML paths)
    }
    if (i != 1)
    {
      stationFullPath = _topDir + "\\Station " + i;
      XMLModificationService.RegisterTwoPlusXMLModifier(RegAndVidTextBoxes(), stationFullPath, "\\Register.cfg", 1, i); 
      // Parameters needed (Multi Dimensional String Array, Full Path for File save location, File Name Used, Index to loop through XML paths, Station Number)
    }
}
```
