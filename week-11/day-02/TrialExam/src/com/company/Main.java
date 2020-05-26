package com.company;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.lang.reflect.Array;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.*;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) throws IOException {
        // write your code here
        //int[][] test = {
        //        {1, 0, 1},
        //        {0, 2, 2},
        //        {1, 2, 5}};
        //int[][] test2 = {
        //        {7, 7, 7},
        //        {6, 5, 7},
        //        {1, 2, 1}};
        //System.out.println(isSymmetric(test2));
        System.out.println(GetTwoMostFrequentChars("file.txt"));

    }

    public static HashMap<Character, Long> GetTwoMostFrequentChars(String path) throws IOException {
        String text = "";
        HashMap<Character, Long> result = new HashMap<>();
        try {
            text = new String(Files.readAllBytes(Paths.get(path)));
        } catch (IOException e) {
            e.printStackTrace();
        }
        // IntStream chars = text.chars();
        //char[] charss = chars.str
        Stream<Character> characterStream = text.chars().mapToObj(c -> (char) c);
        var unsortedHashMap = (HashMap<Character, Long>) characterStream.collect(Collectors.groupingBy(Function.identity(), Collectors.counting())).entrySet().stream().sorted(x -> x.getValue());
        List<Long> list = (ArrayList<Long>) unsortedHashMap.values();
        Collections.sort(list);
        return result;
    }


    public static boolean isSymmetric(int[][] input) {
        for (int row = 0; row < input.length; row++) {
            for (int column = 0; column < input[row].length; column++) {
                if (input[row][column] != input[column][row]) {
                    return false;
                }
            }
        }
        return true;
    }
}
