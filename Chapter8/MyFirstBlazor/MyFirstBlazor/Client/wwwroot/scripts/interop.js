(function () {
  window.blazorLocalStorage = {
    get: key => key in localStorage ? JSON.parse(localStorage[key]) : null,
    set: (key, value) => { localStorage[key] = JSON.stringify(value); },
    delete: key => { delete localStorage[key]; },
    watch: async (instance) => {

      window.addEventListener('storage', (e) => {
        console.log("update");
        instance.invokeMethodAsync('UpdateCounter');
      });

      let time = await DotNet.invokeMethodAsync("Blazor.JSInterop.Client", "GetLocalTime");
      console.log('registering for storage events at ' + time);

    }
  };
})();
