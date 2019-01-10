# Tender Website

Tender website front-end

Smart contract code can be found here: https://github.com/mathusummut/tender

# Steps to Install Tools Required

In this section, you will install the programming tool *Visual Studio Community* and the package manager *node.js*.

1. Firstly, follow this link to download *Visual Studio Community*: https://visualstudio.microsoft.com/downloads/
2. Click the **"Free download"** button under the **Community version section** on the webpage
3. Once downloaded, click the installer
4. Proceed through any popups or menus that appear and wait until *Visual Studio Installer* downloads and installs
5. If granted an option, click **"Install"** in the *Visual Studio Community* section of the *Visual Studio Installer*
6. Proceed through any popups or menus that appear and wait until *Visual Studio Community* downloads and installs
7. If successful, you should have a clean installation of *Visual Studio Community*
8. Next, to install *node.js*, kindly visit this link: https://nodejs.org/en/
9. Click on the button that shows the letters **"LTS"** and the words **"Recommended for most users"**
10. Once the installer downloads, click it
12. Proceed through any popups or menus that appear and complete the installation of *node.js*

# Steps to Install node.js Packages Required

In this section, you will install the packages required to be able to connect to and interact with the blockchain-side of this project. These packages include: *git*, *windows-build-tools*, *ganache-cli* and *ethereum/web3.js*. There are also some extra steps required to make sure that no errors appear during this process.

1. Firstly, open **Start** and type in **"cmd"**
2. Click on the option **"Command Prompt"**
3. After this, *Command Prompt* should open up
4. You may need to change your current directory as sometimes, *Command Prompt* opens on the wrong drive
5. You can do this by simply typing in **"C:"** or whatever **letter your primary drive uses**
6. If you are already on your primary drive, you can skip steps 3 - 5
7. Type in this command in the *Command Prompt*: `npm root --quiet -g`
8. The command should return a directory as a result which you need to highlight and copy
9. Now, you need to check whether you have the **NODE_PATH environment variable**
10. Open **Start** and search for **"This PC"**
11. When the option **"This PC"** appears, right-click on it and choose **"Properties"**
12. After the window loads, navigate to the left side of it and click "Advanced system settings"
13. Then, click **"Environment Variables..."**
14. Here, we will add the **NODE_PATH environment variable** by clicking on **"New..."**
15. In the **"Variable name"** field, type in **"NODE_PATH"**
16. In the **"Variable value"** field, paste the directory we copied from before in the *Command Prompt*
17. After this, click **"OK"**
18. Repeat steps 1 - 5
19. In the *Command Prompt*, type in this command: `npm install git -g`
20. After this, you need to check if *git* is available in your **Path environment variable**
21. To do this, open *Windows Explorer* and navigate to your primary drive (normally **C:**)
22. Navigate to **"Program Files\Git\bin"**
23. Check to see if you have a file named **"git"** in this folder
24. If you do, go to the address bar at the top of *Windows Explorer*, right-click and choose **"Copy address"**
25. After you are done from this, kindly repeat steps 10 - 13
26. Instead of clicking on **"New..."** now, you need to find the **Path environment variable**
27. Once you do, click on it once and click on **"Edit..."**
28. Then, once the new window loads, click on **"New"**
29. After that, paste the address we copied from before and click on **"OK"**
30. Now, open up the *Command Prompt* again and type in this: `npm install windows-build-tools -g`
31. After the installation is done, then type in this: `npm install ganache-cli -g`
32. After that is also done installing, finally, type in this: `npm install ethereum/web3.js -g`
33. If all is successful, then that's it!
