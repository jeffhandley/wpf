#include "win32inc.hpp"

int test_static_abstracts()
{
    int pass = TestStaticAbstracts::TestStaticAbstractsPass::Create();
    int fail = TestStaticAbstracts::TestStaticAbstractsFail::Create();

    return fail;
}
