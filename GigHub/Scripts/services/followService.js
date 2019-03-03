var FollowService = function () {

    var follow = function (followeeId, done, fail) {
        $.post("/api/followings", { followeeId: followeeId})
            .done(done)
            .fail(fail);
    };

    var unFollow = function (followeeId, done, fail) {
        $.ajax({
            url: "/api/followings/" + followeeId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        follow: follow,
        unFollow: unFollow
    };

}();