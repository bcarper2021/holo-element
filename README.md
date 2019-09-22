# holo-element
Product display application for 3D product models on Microsoft Hololens

This application is intended for use in trade shows for products that are too large to take to every trade show. 

The application handles spawning products from a menu of objects. It allows for the manipulation of the objects through space (rotation and translation) using mixed reality toolkit functionality as well as scaling of objects to any size. The application also renders environments that the products can be placed in to show the product in a sample use case.

## Product Menu
The product menu is a panel of all products that can be displayed. An intuitive button layout and click feedback helps the user select various products from the menu. The position of the menu itself can be edited and anchored when needed.

## Product Display
The product display shows the most recent product selected next to the menu. The position of the product display spawn point can be edited for better visibility. The product slowly rotates through a horizontal plane when on display so the user can see all angles of the product.

## Product Information
A short blurb about the product can be included and anchored near the display of the product.

## Product Environment
An environment can be placed in the scene as well. When products are selected from the menu, they are also spawned in the environment and can be manipulated to appear as they would be used in the environment. For example, a company selling tents could show the tent sitting in a forest.
