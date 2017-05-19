#include <cstdio>
#include <ctime>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <numeric>
#include <functional>
#include <random>

constexpr int _8_HOURS = 8 * 3600;

int main()
{
	FILE *input = fopen("input.csv", "r");
	FILE *output_times = fopen("times.dst", "w");
	FILE *output_times_all = fopen("times_all.dst", "w");
	FILE *output_repairs = fopen("repair_counts.dst", "w");
	struct tm t_prev { 0 }, t_cur{ 0 };
	int repair_count;
	int n = 0;
	std::vector<int> repair_counts_analysis(10);

	char tmp[100];
	fgets(tmp, 100, input);
	fscanf(input, "%d. %d. %d %d:%d:%d;%d", &t_prev.tm_mday, &t_prev.tm_mon, &t_prev.tm_year, &t_prev.tm_hour, &t_prev.tm_min, &t_prev.tm_sec, &repair_count);
	t_prev.tm_year -= 1900;
	t_prev.tm_mon--;
	mktime(&t_prev);
	fprintf(output_repairs, "%d\n", repair_count);
	repair_counts_analysis[repair_count]++;
	n++;
	while (fscanf(input, "%d. %d. %d %d:%d:%d;%d", &t_cur.tm_mday, &t_cur.tm_mon, &t_cur.tm_year, &t_cur.tm_hour, &t_cur.tm_min, &t_cur.tm_sec, &repair_count) != EOF)
	{
		t_cur.tm_year -= 1900;
		t_cur.tm_mon--;
		mktime(&t_cur);
		fprintf(output_repairs, "%d\n", repair_count);
		repair_counts_analysis[repair_count]++;
		n++;
		int diff = difftime(mktime(&t_cur), mktime(&t_prev));
		if (t_prev.tm_mday == t_cur.tm_mday && t_prev.tm_mon == t_cur.tm_mon)
		{
			fprintf(output_times, "%d\n", diff);
			fprintf(output_times_all, "%d\n", diff);
		}
		else
		{
			fprintf(output_times_all, "%d\n", diff % _8_HOURS);
		}
		t_prev = t_cur;
	}

	FILE *output_repairs_analysis = fopen("repair_counts_analysis.dst", "w");
	for (size_t i = 0; i < repair_counts_analysis.size(); ++i)
	{
		if (repair_counts_analysis[i] == 0) continue;
		fprintf(output_repairs_analysis, "%zu: %d / %d = %.4f\n", i, repair_counts_analysis[i], n, repair_counts_analysis[i] / static_cast<double>(n));
	}

	fclose(output_repairs_analysis);
	fclose(output_repairs);
	fclose(output_times_all);
	fclose(output_times);
	fclose(input);

	return 0;
}
