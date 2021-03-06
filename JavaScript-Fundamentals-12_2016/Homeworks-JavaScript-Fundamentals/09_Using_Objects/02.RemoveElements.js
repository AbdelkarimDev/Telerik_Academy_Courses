
function solve(args) {
    var element = args[0];

    Array.prototype.removeElement = function (element) {
      var index = this.indexOf(element);
      while(index > -1) {
        this.splice(index, 1);
        index = this.indexOf(element);
      }

      return this;
    };

    console.log(args.removeElement(element).join('\n'));
}
solve(['1', '1', '1', '1']);
solve(['1', '2', '3', '2', '1', '2', '3', '2']);
solve(['_h/_', '^54F#', 'V', '^54F#', 'Z285', 'kv?tc`', '^54F#', '_h/_', 'Z285', '_h/_', 'kv?tc`', 'Z285', '^54F#', 'Z285', 'Z285', '_h/_', '^54F#', 'kv?tc`', 'kv?tc`', 'Z285']);
