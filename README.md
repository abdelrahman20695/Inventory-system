                   Inventory Simulation and Management System

Project Description:
This project is an Inventory Simulation and Management System designed to simplify inventory tracking and simulate various scenarios. The system provides essential features for managing inventory, monitoring low-stock items, and generating reports. It also allows users to run simulations for testing inventory behaviors under different conditions, such as randomly adding products with dynamic attributes like price, quantity, and sales count.
The project is implemented using C# Windows Forms and focuses on creating a user-friendly interface for efficient inventory management.
________________________________________
Project Objectives:
1.	Inventory Management: Keep track of product details, quantities, prices, and sales count.
2.	Simulation: Simulate inventory behaviors to evaluate scenarios like low-stock alerts, product sales, and stock depletion.
3.	Real-Time Updates: Display live updates of inventory data during simulations.
________________________________________
Forms in the Project:
1.	Form1 (Main Form):
o	Purpose: Acts as the central control hub for inventory operations and simulations.
o	UI Elements:
	DataGrid View: Displays the inventory with columns for Name, Price, Quantity, and Sales Count.
	Buttons:
	Add Product: Allows users to manually add a new product to the inventory.
	Start Simulation: Begins a simulation that randomly adds products with dynamic values to the inventory. The button toggles between "Start Simulation" and "Stop Simulation."
	View Reports: Opens the reports form for detailed inventory insights.
	Low Stock Alert: Displays products that are nearing depletion.
________________________________________
2.	Form Reports (Reports Form):
o	Purpose: Displays detailed inventory reports based on user-selected criteria.
o	UI Elements:
	DataGridView:
	Used to show specific data, such as:
	Top-Selling Products: Products with the highest sales count.
	Low Stock Products: Items with quantities below a defined threshold.
	Buttons:
	Export to Excel: Exports the displayed data to an Excel file for further analysis.
________________________________________
Key Features:
1.	Simulation Mode:
o	Generates random products with random names, prices, quantities, and sales counts.
o	Updates the main DataGridView in real-time, showing added products as the simulation runs.
2.	Low Stock Alerts:
o	Identifies and displays products that are low in stock (e.g., quantity ≤ reorder threshold).
o	Helps users prioritize restocking decisions.
3.	Top-Selling Products:
o	Displays products with the highest sales count, aiding in sales analysis.
4.	Dynamic Reporting:
o	Enables users to filter and view specific reports based on inventory status.
5.	Customizable UI:
o	The project features a clean and interactive design, with color-coded DataGridViews and neatly arranged buttons for easy navigation.
________________________________________
Project Importance:
The Inventory Simulation and Management System is particularly useful for small and medium-sized businesses to track and analyze inventory efficiently. It also serves as an educational tool for students learning about simulation and modeling, providing a real-world scenario for understanding inventory behavior.

