# Sitecore Helix Visual Stufio Project Templates with TDS

    Copyright (C) 2017  Cristian Delgado

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    
This repo contains the code used for Visual Studio Templates to create the projects needed for a Sitecore Helix Feature and Project module.

For the Feature module, 5 projects are created:

Solution Folder
    - Web Application: The MVC project for the feature.
    - WebSite: A project for the Frontend assets.
    - TDS Core project: The TDS project for the Core Sitecore Database.
    - TDS Master project: The TDS prokect for the Master Sitecore Database.
    - Tests project: The project for unit testing.

For the Project module the WebSite project is not created, but the code structure of the Web Application is different.