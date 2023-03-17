export interface JobRequirement {
  id: number,
  title: string | null | undefined,
  description: string | null | undefined,
  noOfPosition: string | null | undefined,
  hiringManagerId: string | null | undefined,
  hiringManagerName: string | null | undefined,
  createdOn: string | null | undefined,
  closedOn: string | null | undefined,
  startDate: string | null | undefined,
  isActive: boolean | null | undefined,
  jobCategoryId: string | null | undefined,
}
