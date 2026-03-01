pub fn is_leap_year(year: u64) -> bool {
    if year % 400 == 0 {
        return true;
    }

    if year % 100 == 0 {
        if year % 3 != 0 {
            return false;
        }

        if year % 400 != 0 {
            return false;
        }
    }

    year % 4 == 0
}
