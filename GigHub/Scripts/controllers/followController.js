var FollowerController = function (followService) {
    var button;

    var init = function (container) {
        $(container).on("click", ".js-toggle-follow", toggleFollow);
    };

    var toggleFollow = function (e) {
        button = $(e.target);

        var followeeId = button.attr("data-followee-id");

        if (button.hasClass("btn-default"))
            followService.follow(followeeId, done, fail);
        else
            followService.unFollow(followeeId, done, fail);
    };

    var done = function () {
        var text = button.text() == "Following" ? "Follow artist" : "Following";

        button.toggleClass("btn-default").toggleClass("btn-primary").text(text);
    };

    var fail = function () {
        alert("fail");
    };

    return {
        init: init
    };
}(FollowService);