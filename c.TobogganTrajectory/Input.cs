﻿namespace c.TobogganTrajectory
{
    internal static class Input
    {
    public static string Data =   @"...#...###......##.#..#.....##.
                                    ..#.#.#....#.##.#......#.#....#
                                    ......#.....#......#....#...##.
                                    ...#.....##.#..#........##.....
                                    ...##...##...#...#....###....#.
                                    ...##...##.......#....#...#.#..
                                    ..............##..#..#........#
                                    #.#....#.........#...##.#.#.#.#
                                    .#..##......#.#......#...#....#
                                    #....#..#.#.....#..#...#...#...
                                    #.#.#.....##.....#.........#...
                                    ......###..#....#..#..#.#....#.
                                    ##.####...#.............#.##..#
                                    ....#....#..#......#.......#...
                                    ...#.......#.#..#.........##.#.
                                    ......#.#.....###.###..###..#..
                                    ##..##.......#.#.....#..#....#.
                                    ..##.#..#....#.............##.#
                                    ....#.#.#..#..#........##....#.
                                    .....####..#..#.###..#....##..#
                                    #.#.......#...##.##.##..#....#.
                                    .#..#..##...####.#......#..#...
                                    #...##.......#...####......##..
                                    ...#.####....#.#...###.#.#...#.
                                    ....#...........#.##.##.#......
                                    .....##...#.######.#..#....#..#
                                    .#....#...##....#..######....#.
                                    ...#.....#...#####.##...#..#.#.
                                    .....#...##........##.##.##.###
                                    #.#..#....##....#......#....#.#
                                    ......##...#.........#....#.#..
                                    ###..#..##......##.#####.###.##
                                    #.....#..##.##....#...........#
                                    ##..#.#..##..#.#.....#......#..
                                    .#.##.#..#.#....##..#..#....#..
                                    .#......##..##.#...#..#.......#
                                    #....##.##..###..###......##.#.
                                    ....###..##.......#.###.#....#.
                                    ..##........#........##.....#..
                                    .#..#.....#...####.##...##.....
                                    ....#.#.#.....#.##..##.....#..#
                                    ..............#.....#...#.....#
                                    .#.....#......###...........#.#
                                    .....#.#......#.##..#..........
                                    .#......###............#.#.##..
                                    .#.#....##.#..###.....#.##..#.#
                                    .......#.#.#..#..#..#...##..#.#
                                    .#.###...##.#.#.####.#.#...#...
                                    ...#.#....#......##.##.#.......
                                    #...#.....##....#........##....
                                    .....###...#.##.#......##.#..#.
                                    ..#...##.##.###..#..#......####
                                    .#.##.#..#.##..##..........##..
                                    ..#.#.#..#.#.....#...###.....#.
                                    ..#..#.#....#.##.............##
                                    .......#..###..#.#...#.....##.#
                                    ####.#.#......#..#.##.........#
                                    ..........#.....#..##......###.
                                    ..#..............#...#..##.....
                                    ......#.#.#..#.##.....####..##.
                                    .##.#..#.#....#.......#..#.....
                                    ..#..#..#.##.#....###.#.#.#.#.#
                                    .....#....#......###..#........
                                    #.#.#..#...###.....#......#.##.
                                    ...#.#....#.#......#........#..
                                    ..#...###.#...#..#....##...#..#
                                    .###.##..#..#...###.#..#.####..
                                    #....#..##..##..#......#...##..
                                    #.#..#...#..#...###..#.#.##....
                                    ##....#....##.####...#.#.###...
                                    ##.#...#.......#.##.##....#...#
                                    ..#.#..........#..#.#.#....#..#
                                    ..#........#...#....#....#....#
                                    ..#..#....#.......#........#...
                                    ......#....#....##.#....#.#.##.
                                    .##...###.##.##....##.#...###..
                                    .....##..#.#.....###..#.....###
                                    ....##.#.##...##..##........#..
                                    #...#..##.#.#....#......#...#..
                                    .###.##.#........#.####....#...
                                    #.##.....#..#...#..##.##..#.#..
                                    .....#.#..#....#..#...##.##.#..
                                    .#......#####...##...#.#.###.#.
                                    #......##....#.....#......##.#.
                                    #.#.##.###.#......#####..#.....
                                    ........###.#...#..#.#........#
                                    ....#....###..#.##.#...#....#..
                                    ..........#..#.#....#...#.#...#
                                    #.##......###.#.#.#....####...#
                                    ...#.#....#........##.#.....##.
                                    .....##..#.#.#..###...##...#...
                                    #...#...#....#....##........#..
                                    .....#.........##.#......#..#..
                                    #.....##..#.###.....#....##.##.
                                    ...#..#..#.#........##...##.#.#
                                    ..#..##.###.....#.#.....###.##.
                                    ..###.........#...##.....###...
                                    ...###...##.#...##....##.......
                                    .#.#..#...###..#.#....#....#...
                                    ##..#.......#....#.#...#..#..#.
                                    ..#......#....####..##..#.###.#
                                    ..#.......##........#.#.#..#...
                                    .#.......#.##.#.##.#.......#..#
                                    ###...#...#...#...#..#...#...##
                                    ..#..........#..###........##..
                                    .##..#....##......##........#.#
                                    ......#.##......#......##...#.#
                                    .#.#....#.#.#........#......#..
                                    .#.#..#....####..##...##....#..
                                    .#...##..#..#..#####....##.#...
                                    .##.#.#...#...#.#...#.##.#...#.
                                    ###.#...##..#.###.#.....#.##.#.
                                    #.....#.###.#.#...#..#....#.#..
                                    ..##..#....#......#.........###
                                    .#...#...##......#...#.####....
                                    ..#.##...##..............#.#..#
                                    ..#......#..##...........#..#.#
                                    ..#####...#..#.......##...###..
                                    ..##..#....#.#...###.#...#.....
                                    ..#....#..#.#.......#..#.#.#...
                                    .##..#.#.....##....#.......#...
                                    ...#.#..###...##....#....##..#.
                                    .....##..#...##.####....##...#.
                                    .......#.........#...#.##..####
                                    ........###..#..#.##.###..#....
                                    .#.#..#.##.##.........#...#....
                                    .###......#.....#....##....####
                                    .##..##...........#.....#.....#
                                    #.#.#.#.#.#.##..#.#.#..#.##....
                                    .##.##...##..#....##..###..####
                                    #..##.#......#...###.........#.
                                    #..#...#..##..#..##.....##...#.
                                    #...##..#...##.#.###.#...#.....
                                    .###.....#.......#...#.##.###.#
                                    ..........#.#......#...###...##
                                    ..##....#.#..#....#.###...#..##
                                    #.#..#....##.##..##.........##.
                                    #.....#.##.###.#..#....##...#..
                                    ...#........##...#..###..######
                                    #..#.#.#.#...#....#....###.#..#
                                    ...##.##.##.....##..#........#.
                                    ..#.#....#..#.......#...##.##.#
                                    ###.##.......##..#.####...#.#..
                                    ....#.#.....##.....#.#.##...#..
                                    .#..##..#.....#.#..#...#..#..#.
                                    .###....##...#......#.....#....
                                    ##.##.###......#...#...###.#...
                                    #...#.##...#.#....##.....####..
                                    #.#.#.#...###...##.............
                                    ..#....#.....##.#...#......#...
                                    ....#...#......#...#..#...#.#..
                                    .###..#.....#..#...#....#...#..
                                    ..#...#.#..###.......#..#.#...#
                                    #...###.##.....#....#..#.#..##.
                                    ...#.##.#.##......#.#.#.##.....
                                    ........####...##...##..#....#.
                                    .#.#....#....#.#...##.###...##.
                                    #.#...###.#.#.#....#....#.#....
                                    .####.#..#.#....#..#.#..#..#...
                                    #####...#...#...#....#.#.#..##.
                                    ..###.##.###...#..........#.##.
                                    ##.....#...#....###..###.#.#.#.
                                    #..##.#..#..#..#...#.#...###..#
                                    ##....#.#...##......#.#...#...#
                                    .##..........#.#....#...#.##..#
                                    ....#....####.#.####......#.###
                                    ..##.#.....####.#.####.......#.
                                    #.##.##.#.....#.##......##...#.
                                    ......###..#.....#.....##......
                                    ..#..#....#.#...#.....#......##
                                    ##..#..#..###.#.#..#..##.....#.
                                    #....#.#.....#####...#.#.......
                                    .....#..#....#.#.#..#...#...#..
                                    ............#.##......##.##.#.#
                                    ....#...#.#........###....#....
                                    ..#..#...###.#....##..#..###.##
                                    #.##....#...#.....##..#.##.#...
                                    ...##..###...#.#.....##.#......
                                    .#..#.##.#####..#.......#..###.
                                    ...#.##...###.....####.#.#.....
                                    .#......##.#.#.#.#.##.#.....#..
                                    ..#.##.#..##.......#.#.....##..
                                    ..................#....#...#...
                                    .##.#..#.#.#..#.......#.#..##.#
                                    ....#........#......#..####..#.
                                    #...#...##..##.#..#.......##...
                                    #..#..#..#..#........####..#.#.
                                    ..#.#......#..#.##.##.#.#...#.#
                                    ...#..#......#.#.###.#.##..##..
                                    ..#...##.....#..#...##..#.#....
                                    #.........#....#..#....##.##..#
                                    ..#..#.#....#..#...#.##.....#..
                                    ...#..#...#.#.....#..##..#.#...
                                    ....#........#.#....##..##..#..
                                    #.....#.#..#.......#.##.....#..
                                    .#.###.###...##...##..###...#..
                                    .##.##.......#.#......#.....#.#
                                    ...#....##....#..#..........#.#
                                    ..#.##.........#.#.....#.....#.
                                    ...#.##..##.......##..##...#...
                                    #.##......##.##..#.....##...##.
                                    #.#.#..##...#.#............#.#.
                                    ....#.....#......##...#.#.....#
                                    ...#.#......#.#...###.......#..
                                    ......##..###....#.#...#.#####.
                                    ..#..#.#.#...##.#...###..##..#.
                                    ##.##.#.#.##.#..#....#...#...#.
                                    #..#....######.##.#...#...#.#..
                                    .#..#.##....#..#.#.......#....#
                                    ....#....#......##....##.#.#...
                                    .###......#..#..#.......####..#
                                    .#.#.....#..###...........##...
                                    .##..##.##.....####..#..#..##..
                                    ..#..##.#......#...###.##..#.#.
                                    ....##..#.....###..#.##....##.#
                                    #..#......#....#.........#.....
                                    .#...#.....#.#..#..##....#.....
                                    .##..#...#..##.#..#...........#
                                    ..#..##........##.......#..#...
                                    #.....#....#....#.#.#...##.#...
                                    ...#...#.#.#..#.##.#.#...#.....
                                    ..#..#.#....#....###....#.#.#..
                                    ...###..#...#..#....#.....#....
                                    ...#...#.#..#.....#...###......
                                    ##......#..........#.#.#..#.#.#
                                    ....#.....#.....#..#..#.#.#.#..
                                    ...####...#.##...#.#..#....#.#.
                                    #.##........##.............#.##
                                    #.#.#.#.#.....................#
                                    .#.###....#..##.##.##....#.....
                                    #.#...#.####.###...#..#..#.#...
                                    .##...#..###.......##..#.#.....
                                    #.#.#.#...#...#.##.....#.......
                                    .##.#.#.#......####..#.#.......
                                    ###..........#......#...##...#.
                                    .........##...#.##...#.#.......
                                    ...#.#.....#...#..#...#..##..#.
                                    .#..###...#.#.........###....#.
                                    ##..#...#........#.........##..
                                    .....#...#.#...#.#.#...........
                                    ..#....##...#.#..#..#.##....##.
                                    .##....#.#.....##.#..#..#...##.
                                    ..##......#.#...#.#.......##.#.
                                    ##...#..#...##.#........#.##...
                                    #......#.##..#.#..#.###.......#
                                    #.#...#.....#.#......#.#.#.....
                                    #.....#..#.......#....##.#.#..#
                                    ###.#....#..##.#.##....#....#..
                                    #.##.##....#.#..#.#...#....#...
                                    ####...#####...#.....#....##.#.
                                    ....#.#...#.#.##.#.#.##.#.#.###
                                    #.....##.#.....#.#......#.#..#.
                                    .#....##.#..#........#...##.#..
                                    ......#...#....##....##....##..
                                    ..###.....#....##.#...#..#.....
                                    #....##...##.##..##.#...#...#..
                                    #..#...#...#.#....##..#.#....#.
                                    ......................#.....#..
                                    .#..#...#.........#....##...###
                                    .##.#.#...##...#...#...#..#....
                                    .#.###....#.#............##..#.
                                    ###..##.#.#.#.#....##...#......
                                    .##................####...##.##
                                    .#.#.........##....#.#.##.##.#.
                                    ....#...#...#...##...#.##.#..#.
                                    .#.#........#..##.....#..#....#
                                    ##.#..#.#....#.....#...#...#...
                                    .#...##....#.....##....#..#.#.#
                                    ####.....#..#....#......###.##.
                                    ##..##.#....###.....#...#......
                                    .##.#...#.....#.#..#.#..#.#...#
                                    .....#.#..#..#..###.#...###.#..
                                    .#.#.##.#..#.#..#...#..#.......
                                    ..#.....#....#.##.##.##.......#
                                    .#..##....###...#..............
                                    #....#...#.#.......#....##.#...
                                    ....#.#..##.#....#..#.#....#.#.
                                    #.........##...#.#.............
                                    #.#.......##.....#...##..##.#.#
                                    .......#....#..##...#..#######.
                                    .#.#...##........#..#.....#.#..
                                    .#.......#..#......#.##.##...##
                                    .........#............#....#..#
                                    .#......#...##...##...#....###.
                                    .........#...#.#.###.......#...
                                    ###.#..#.#.#.#......##...#.#...
                                    .#.........##.#....###....#.#..
                                    #.#....#..#.##.#..#....##...#..
                                    ###.#...#..#..##........#.###..
                                    .....#....#..#........#..#.##.#
                                    ..#.....##......#....#..#.#.#..
                                    .#.........#.....#.....#.......
                                    ......#....#.###..#.#....#....#
                                    ..#.#..#.#.###.........#..#..#.
                                    ..#..#.#.#.........#....##.#.#.
                                    #.......#........##...##....#..
                                    ##..#..#...###...#..##..#..#.#.
                                    ##..#..#....#.#..##..#..#.#..#.
                                    ..##.....##.#..#.#........###..
                                    ..#.#..#..##........#...#....##
                                    .##..#....##..#..#..#..#.#....#
                                    #....#.....##........#.....#.##
                                    ......#....#.#..#......#.##....
                                    .......#..#..#......##.........
                                    ......#...#..##.....#......#..#
                                    #..#..#....##....#........##..#
                                    ##....#...#.#.....#####........
                                    ...#.#..#.#.##.#.##..##...#....
                                    ..#..#..#..#..#....#..#..##...#
                                    .#.....#....##.##....##.....#..
                                    #...#.....#.....#.#...#.#....#.
                                    .###...#..##....#..#...#.###...
                                    ....#..##..#.......#.##.##..###
                                    #.......##.....#.......#.#...##
                                    #.....#.#.#....#.#......#.#.#..
                                    ..##.....#..###......##........
                                    .....#...#..##....#......#.....
                                    #..#..#....#.#...#..###.......#
                                    .....#.....#....#..#...#.#..##.
                                    #####........#...#..#..##..#.#.
                                    .#..#...#.##....#.#..#......###
                                    #.###.#..#.....##..##....#...#.
                                    .#...#.#####....##..........##.";
    }
}