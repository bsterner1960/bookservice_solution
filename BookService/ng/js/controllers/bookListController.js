﻿// This controller is going to provide a list of books based on a search result.
app.controller("bookListController", ["$scope", "$rootScope", "Search", function ($scope, $rootScope, Search) {
    console.log("bookListController is alive!, RockOn!");

    // Where to put the alerts
    $scope.alerts = [];

    // This will remove the alert popup
    $scope.closeAlert = function (index) {
        $scope.alerts.splice(index, 1);
    };

    // Using this to make sure a serach is not sent to the backend 
    // when only initializing the controller for the first time
    // we need only to react on a real search.
    var myFirstRun;

    //using $rootScope.watch to listen for new data on "bookSearchValue"
    $rootScope.$watch("bookSearchValue", function (data) {

        // Are we running this for the first time (the controller is included in code somewhere)
        if (myFirstRun === undefined) {
            myFirstRun = false;
            // Nope, not first time the controller is used so then we assume we got a search to work with.
        } else {
            $scope.books = Search.index({ whatToSearchFor: "books", searchValue: data },
                //On succsess (if you want to do anything on success you can add it here
                function (data) {
                    // Nothing to see here yet, just move along and have a good day :-).
                },
            // And here we can handle stuff when something goes wrong
            // for example show an error message to the user
            function (error) {
                //On error
               // console.log("Ojsan, fick problem när jag kallade på servern " + error.status + " " + error.statusText + "");
                $scope.alerts.push({ type: 'danger', msg: "Kära hjärtanes något gick snett! Fick problem när jag kallade på servern " + error.status + " " + error.statusText + "" });
               
            });

        }
    });

}]);