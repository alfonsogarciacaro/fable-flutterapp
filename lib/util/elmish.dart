import '../fable_modules/fable_library/Types.dart';
import 'package:flutter/material.dart';

class ElmishState<Model, Msg> extends State<ElmishWidget<Model, Msg>> {
    Model? _state;
    ElmishState(): super();

    @override
    Widget build(BuildContext context) {
        void dispatch(Msg msg) {
            setState(() {
                _state = widget.update(msg, _state!).item1;
            });
        }
        _state ??= widget.init().item1;
        return widget.view(_state!, dispatch);
    }
}

class ElmishWidget<Model, Msg> extends StatefulWidget {
    final Widget Function(Model, Function(Msg)) view;
    final Tuple2<Model, Iterable<Function(Function(Msg))>> Function(Msg, Model) update;
    final Tuple2<Model, Iterable<Function(Function(Msg))>> Function() init;
    const ElmishWidget(this.init, this.update, this.view, [Key? key]): super(
        key: key
    );
    @override
    State<ElmishWidget<Model, Msg>> createState() => ElmishState<Model, Msg>();
}
