package game;

import javax.swing.*;
import java.awt.*;

public class GameWindow extends JFrame {
    public GameWindow (){
        JPanel jPanel = new JPanel();
        this.add(jPanel);
        this.setTitle("Othello Game");
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.pack();
        this.setVisible(true);
        this.setSize(1080,740);
    }

    public static void main(String[] args) {
        new GameWindow();
    }
}
