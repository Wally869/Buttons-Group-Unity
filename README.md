# Buttons Group for Unity

This repository contains a prefab and related scripts to create a Buttons group for Unity.

## What is a Buttons Group?

It is a group of buttons (duh) with a parent ButtonsGroupController. On clicking a button, the button notifies its parent of the event. The ButtonsGroupController records the new state for the button, and changes the state of other buttons.

The main use for this prefab is to create "Radio Buttons", meaning only one button can be active at a time. The gifs show it working (low quality gifs, will be updated).

It also enables the developper to have access to different buttons state from a single class instead of checking it from multiple buttons, but the main intent was reusability for UI creation.

![Exclusive Selection](img/buttons-group_exclusive.gif)  
Buttons group in action, with exclusive selection turned on.


![Non-Exclusive Selection](img/buttons-group_nonexclusive.gif)  
It also supports non exclusive selection.


## Features

Support for clicks and hover detection, exclusive and non-exclusive selection.

The ButtonsGroup also autodetects its children buttons and gives them an index on start for reference in notifications. This means you can easily add/delete buttons.

Finally, it is possible to set the first button in the list as on by default.


## How to Use

Paste the Prefab and the scripts in your Asset folder, instantiate a ButtonsGroup, set the desired colors and image/material for idle/hover/active states and voila! You're done!

![Inspector View of ButtonsGroup](img/inspector-buttonsGroup.png)   
Inspector View of Buttons Group

Set bIsExclusive as true to enable exclusive selection.  
Set bFirstButtonActive to set the first button as active on start.

The buttons objects are not Unity UI buttons, but simple Monobehaviour classes implementing interfaces to detect clicks and hovers (IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler).

To interface with another class, such as a GameManager, you can access the current active states of button by using the method GetListActiveButtons of the ButtonsGroupControl class.

## Usage Notes

IMPORTANT: this implementation allows having no active buttons.


