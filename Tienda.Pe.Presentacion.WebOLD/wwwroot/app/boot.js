System.register(["angular2/plataform/browser", "./MyApp"], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var browser_1, MyApp_1;
    return {
        setters:[
            function (browser_1_1) {
                browser_1 = browser_1_1;
            },
            function (MyApp_1_1) {
                MyApp_1 = MyApp_1_1;
            }],
        execute: function() {
            browser_1.bootstrap(MyApp_1.MyApp);
        }
    }
});
//# sourceMappingURL=boot.js.map