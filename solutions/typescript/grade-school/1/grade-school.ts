export default class GradeSchool {
  private roster: Map<string, string[]> = new Map();

  studentRoster() {
    const roster = new Map();

    for (const [key, value] of this.roster) {
      roster.set(key, [...value]);
    }

    return roster;
  }

  addStudent(name: string, grade: number) {
    this.roster.set(
      grade.toString(),
      this.studentsInGrade(grade).concat(name).sort()
    );
  }

  studentsInGrade(grade: number): string[] {
    return [...(this.roster.get(grade.toString()) || [])];
  }
}
