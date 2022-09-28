use adventofcodelibrary::{dayone, daytwo};

fn main() {
    // TODO: Implement a menu to select which day to run
    let day_one_part_one = dayone::DayOne::part_one();
    let day_one_part_two = dayone::DayOne::part_two();
    let day_two_part_one = daytwo::DayTwo::part_one();
    let day_two_part_two = daytwo::DayTwo::part_two();

    // TODO: Do this better
    println!("----------------------");
    println!("Advent of code - 2015");
    println!("----------------------");
    print_result(day_one_part_one, day_one_part_two, 1);
    print_result(day_two_part_one, day_two_part_two, 2);
}

fn print_result(part_one: i32, part_two: i32, day: i32) {
    println!("Day {}: Part {}: Result {}", day, 1, part_one);
    println!("Day {}: Part {}: Result {}", day, 2, part_two);
    println!("----------------------");
}
