export interface Account {
  id: number,
  firstName: string | null | undefined,
  lastName: string | null | undefined,
  emloyeeId: string | null | undefined,
  email: string | null | undefined,
  hashPassword: string | null | undefined,
  salt: string | null | undefined,
}
