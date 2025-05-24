package game;

import java.awt.*;

public class GamePlayer {
    protected int myMark;

    public GamePlayer(int mark){
        this.myMark = mark;
    }
    public boolean isUserPlayer;
    public String playerName;
    public Point play(int[][] board);

}
