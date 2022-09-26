use std::fs::File;
use std::io::{BufRead, BufReader};

pub struct DayOne;

impl DayOne {
    pub fn part_one() -> i32 {
        let file = BufReader::new(File::open("input.txt").expect("open failed"));

        let mut floor = 0;

        for line in file.lines() {
            for character in line.expect("lines failed").chars() {
                if character == '(' {
                    floor = floor + 1;
                } else if character == ')' {
                    floor = floor - 1;
                }
            }
        }

        return floor;
    }

    pub fn part_two() -> i32 {
        let file = BufReader::new(File::open("input.txt").expect("open failed"));

        let mut floor = 0;
        let mut character_number = 0;

        for line in file.lines() {
            for character in line.expect("lines failed").chars() {
                character_number = character_number + 1;

                if character == '(' {
                    floor = floor + 1;
                } else if character == ')' {
                    floor = floor - 1;
                }

                if floor == -1 {
                    return character_number;
                }
            }
        }

        return character_number;
    }
}
