﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KnockoutJS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Knockout cart</title>
    <script src="scripts/jquery-3.3.1.js"></script>
    <script src="scripts/knockout-3.4.2.js"></script>
    <script src="scripts/jquery.tmpl.js"></script>
    <script src="scripts/jquery-3.3.1.intellisense.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Enter Menu Items</h1>
        </div>
    
        <div>
            <p>Entree: <input type="text" data-bind="value: name"/></p>
            <p>Price: <input type="text" data-bind="value: price" /></p>
            <button data-bind='click: addProduct'>Add item</button>
        </div>
        <ul data-bind="foreach: products">
            <li>
            <span data-bind="text: name"></span>
            <span data-bind="text: price"></span>
            <button type ="button" class =" btn btn-default btn-sm" data-bind='click: $parent.deleteItem'><span class="glyphicon glyphicon-trash"></span></button>  
                
            </li>
        </ul>
  


    <script type="text/javascript">
        function Product(name, price) {
            return {
                name: ko.observable(name),
                price: ko.observable(price)
            }
        }

        var vm = {
            name: ko.observable("New Entree"),
            price: ko.observable("0"),
            products: ko.observableArray([new Product("Bread", "$4"), new Product("Water", "$2")]),

            addProduct: function () {
                vm.products.push(new Product(this.name(), this.price()));
            }
        }

        vm.deleteItem = function () {
            vm.products.remove(this);
        }

        ko.applyBindings(vm);

    </script>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
        </body>
</html>
