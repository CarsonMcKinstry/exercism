def convert(number):
  result = ''
  div3 = number % 3 == 0
  div5 = number % 5 == 0
  div7 = number % 7 == 0
  if div3:
    result += 'Pling'
  if div5:
    result += 'Plang'
  if div7:
    result += 'Plong'
  if (not div3 and not div5 and not div7):
    result += str(number)
  return result
