/// <reference path="C:\Users\aesmailzadeh\Desktop\IISNet\WebApplication1\angular.min.js" />
var app = angular
            .module("Demo",  ["ngRoute"])
            .config(function ($routeProvider) {
                $routeProvider
                    .when("#/home", {
                        templateUrl: "HtmlPage1.html",
                        controller: "homeController"
                    })
                   .otherwise({
                       templateUrl: "HtmlPage1.html",
                       controller: "homeController"
                   });
            })
            
             .controller("homeController", ['$scope', '$http',

                function ($scope, $http) {
                    $http.get('WebService1.asmx/GetAllMCs').then(function (response) {
                        $scope.MCs = response.data;
                        return $http.get('WebService1.asmx/GetAllCampaigns');
                    }).then(function(response) {
                        $scope.Campaigns = response.data;
                    });
             
                    $scope.FindCamp = function () {
                        $http({
                            url: 'WebService1.asmx/SelectSomeCampaign',
                            method: "GET",
                            params: { MCID: $scope.McID }
                        })
                        .then(function (response) {
                            $scope.SomeCamps = response.data;
                         
                        }, function (error) {
                           console.error(error);
                        });
                    }

                    $scope.InsertMcCamp = function () {
                        $http.post('WebService1.asmx/InsertMcCampaign', { MCID: $scope.McID, CampaignID: $scope.CampID }, { headers: { 'Content-Type': 'application/json; charset=utf-8', 'dataType': 'json' } })
                        .then(function(response){
                            console.log("Data Inserted Successfully");

                            $scope.FindCamp();

                        },function(error){
                            alert("Sorry! Data Couldn't be inserted!");
                            console.error(error);
                        });
                    }
                                       
                    $scope.DeleteCamp = function () {
                       
                        $http.post('WebService1.asmx/DeleteMCCampaign', { MCID: $scope.McID, CampaignID: $scope.CampID1 }, { headers: { 'Content-Type': 'application/json; charset=utf-8', 'dataType': 'json' } })
                        .then(function (response) {
                            console.log("Data deleted Successfully");

                            $scope.FindCamp();

                        }, function (error) {
                            alert("Sorry! Data Couldn't be deleted!");
                            console.error(error);
                        });
                    }
                                       

                }]);
                       

var app = angular.module('myApp', []);
app.controller('formCtrl', function ($http, $scope) {
   
    $http.get('WebService1.asmx/SelectNonProcessed').then(function (response) {
        $scope.NonProcesseds = response.data;
    });

});