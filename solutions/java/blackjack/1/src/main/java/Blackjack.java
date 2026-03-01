public class Blackjack {

    public int parseCard(String card) {
        int val;
        switch (card) {
            case "ace":	
                val = 11;
                break;
            case "eight":	
                val = 8;
                break;
            case "two":	
                val = 2;
                break;
            case "nine":	
                val = 9;
                break;
            case "three":	
                val = 3;
                break;
            case "ten":	
                val = 10;
                break;
            case "four":	
                val = 4;
                break;
            case "jack":	
                val = 10;
                break;
            case "five":	
                val = 5;
                break;
            case "queen":	
                val = 10;
                break;
            case "six":	
                val = 6;
                break;
            case "king":	
                val = 10;
                break;
            case "seven":	
                val = 7;
                break;
            default:	
                val = 0;
        }
        return val;
    }

    public boolean isBlackjack(String card1, String card2) {
        return parseCard(card1) + parseCard(card2) == 21;
    }

    public String largeHand(boolean isBlackjack, int dealerScore) {
        if (!isBlackjack) {
            return "P";
        } else if (dealerScore < 10) {
            return "W";
        } else {
            return "S";
        }
    }

    public String smallHand(int handScore, int dealerScore) {
        if (handScore >= 17) {
            return "S";
        }

        if (handScore <= 11) {
            return "H";
        }

        if (dealerScore >= 7) {
            return "H";
        }

        return "S";
    }

    // FirstTurn returns the semi-optimal decision for the first turn, given the cards of the player and the dealer.
    // This function is already implemented and does not need to be edited. It pulls the other functions together in a
    // complete decision tree for the first turn.
    public String firstTurn(String card1, String card2, String dealerCard) {
        int handScore = parseCard(card1) + parseCard(card2);
        int dealerScore = parseCard(dealerCard);

        if (20 < handScore) {
            return largeHand(isBlackjack(card1, card2), dealerScore);
        } else {
            return smallHand(handScore, dealerScore);
        }
    }
}
