import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {

        List<Signal> instructions = new ArrayList<>();

        boolean shouldWink = (number & 0b00001) == 1;
        boolean shouldDoubleBlink = (number & 0b00010) == 2;
        boolean shouldCloseYourEyes = (number & 0b00100) == 4;
        boolean shouldJump = (number & 0b01000) == 8;
        boolean reverse = (number & 0b10000) == 16;

        if (shouldWink) {
            instructions.add(Signal.WINK);
        }
        if (shouldDoubleBlink) {
            instructions.add(Signal.DOUBLE_BLINK);
        }
        if (shouldCloseYourEyes) {
            instructions.add(Signal.CLOSE_YOUR_EYES);
        }
        if (shouldJump) {
            instructions.add(Signal.JUMP);
        }
        if (reverse) {
            Collections.reverse(instructions);
        }

        return instructions;
    }

}
