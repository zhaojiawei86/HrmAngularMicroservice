export interface Submission {
  id: number,
  candidateId: string | null | undefined,
  jobRequirementId: string | null | undefined,
  appliedDate: string | null | undefined,
  confirmedOn: string | null | undefined,
  rejectedOn: string | null | undefined,
  submissionStatusId: string | null | undefined,
}
